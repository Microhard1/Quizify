using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class EstadisticasAlumno : Form
    {
        Dictionary<string, CalificacionVF> diccionarioCalificacion;
        MyQuizifyServices services = new MyQuizifyServices();
        public EstadisticasAlumno()
        {
            InitializeComponent();
            diccionarioCalificacion = services.getDiccionarioCalificacionesAlumno();
            dataGridEstadisticas.Columns.Add("nombre", "Nombre");
            dataGridEstadisticas.Columns.Add("apellidos", "Apellidos");
            dataGridEstadisticas.Columns.Add("nota", "Nota");
            mostrarEstadisticas();
        }
        public void mostrarEstadisticas()
        {
            double media = 0, maxima = 0, minima = 10;
            int count = 0;
            foreach (var calificacion in diccionarioCalificacion)
            {
                dataGridEstadisticas.Rows.Add(calificacion.Value.examinado.nombre, calificacion.Value.examinado.apellidos, calificacion.Value.nota);
                media = media + calificacion.Value.nota;
                count++;
                if (maxima < calificacion.Value.nota) { maxima = calificacion.Value.nota; }
                if (minima > calificacion.Value.nota) { minima = calificacion.Value.nota; }
            }
            media = media / count;
            lblMedia.Text = media.ToString();
            lblMaxima.Text = maxima.ToString();
            lblMinima.Text = minima.ToString();
        }
        private void btbVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string texto = textoBusqueda.Text;
            dataGridEstadisticas.Rows.Clear();
            foreach (var calificacion in diccionarioCalificacion)
            {
                if (calificacion.Value.examinado.nombre == texto || calificacion.Value.examinado.apellidos == texto)
                {
                    dataGridEstadisticas.Rows.Add(calificacion.Value.examinado.nombre, calificacion.Value.examinado.apellidos, calificacion.Value.nota);
                }
            }
        }

        private void botonRecargar_Click(object sender, EventArgs e)
        {
            dataGridEstadisticas.Rows.Clear();
            mostrarEstadisticas();
        }
    }
}
