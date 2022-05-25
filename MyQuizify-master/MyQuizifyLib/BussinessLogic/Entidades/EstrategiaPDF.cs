using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MyQuizifyLib.Persistencia;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class EstrategiaPDF : EstrategiaInforme
    {
        public void generarInforme(List<Calificacion> calificaciones, Quiz q)
        {
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\sanco\Desktop\" +
                q.nombreQuiz + ".pdf", FileMode.Create));
            doc.AddTitle("Calificaciones Quiz : " + q.nombreQuiz);
            doc.AddCreator(ConexionBD.getInstancia().usuarioConectado.username);
            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA,
                8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            PdfPTable tabla = new PdfPTable(3);
            tabla.WidthPercentage = 100;

            PdfPCell Nombre = new PdfPCell(new Phrase("Nombre", _standardFont))
            {
                BorderWidth = 0,
                BorderWidthBottom = 0.75f
            };

            PdfPCell Apellidos = new PdfPCell(new Phrase("Apellido", _standardFont));
            Apellidos.BorderWidth = 0;
            Apellidos.BorderWidthBottom = 0.75f;

            PdfPCell Nota = new PdfPCell(new Phrase("Nota", _standardFont));
            Nota.BorderWidth = 0;
            Nota.BorderWidthBottom = 0.75f;

            tabla.AddCell(Nombre);
            tabla.AddCell(Apellidos);
            tabla.AddCell(Nota);

            foreach (Calificacion c in calificaciones)
            {
                Nombre = new PdfPCell(new Phrase(c.examinado.nombre, _standardFont));
                tabla.AddCell(Nombre);
                Apellidos = new PdfPCell(new Phrase(c.examinado.apellidos, _standardFont));
                tabla.AddCell(Apellidos);
                Nota = new PdfPCell(new Phrase(c.nota.ToString(), _standardFont));
                tabla.AddCell(Nota);
            }

            doc.Add(tabla);
            doc.Close();
            writer.Close();

        }
    }
}