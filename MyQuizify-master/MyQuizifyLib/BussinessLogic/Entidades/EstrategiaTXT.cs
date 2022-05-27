using System.Collections.Generic;
using System.IO;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class EstrategiaTXT : EstrategiaInforme
    {
        public void generarInforme(List<Calificacion> calificaciones, Quiz q)
        {
            int counter = 0;
            string[] lines = new string[calificaciones.Count];
            foreach (Calificacion c in calificaciones)
            {
                lines[counter] = "Nombre y apellidos : " + c.examinado.nombre + " " + c.examinado.apellidos
                    + "...................Nota : " + c.nota;
                counter++;
            }
            string path = @"C:\Users\sanco\Desktop\Notas" + q.nombreQuiz + ".txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (string line in lines) sw.WriteLine(line);
            }
        }
    }
}
