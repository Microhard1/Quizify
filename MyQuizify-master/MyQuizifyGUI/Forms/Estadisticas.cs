using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class Estadisticas : Form
    {
        private Quiz quiz;
        private MyQuizifyServices services;
        private Dictionary<string, CalificacionVF> diccionarioCalificacion;
        
        public Estadisticas(Quiz q)
        {
            InitializeComponent();
            quiz = q;
            services = new MyQuizifyServices();
            lblNombreQuiz.Text = quiz.nombreQuiz;
            diccionarioCalificacion = new Dictionary<string, CalificacionVF>();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            dataGridEstadisticas.Columns.Add("nombre", "Nombre");
            dataGridEstadisticas.Columns.Add("apellidos", "Apellidos");
            dataGridEstadisticas.Columns.Add("nota", "Nota");
            diccionarioCalificacion = services.getDiccionarioCalificacionVF(quiz);
            mostrarEstadisticas();
        }
        public void mostrarEstadisticas()
        {
            double media = 0, maxima = 0, minima = 10;
            int count = 0;
            if (diccionarioCalificacion != null)
            {
                foreach (var calificacion in diccionarioCalificacion)
                {
                    if (calificacion.Value.quizRealizado.nombreQuiz == quiz.nombreQuiz)
                    {
                        dataGridEstadisticas.Rows.Add(calificacion.Value.examinado.nombre, calificacion.Value.examinado.apellidos, calificacion.Value.nota);
                        media = media + calificacion.Value.nota;
                        count++;
                        if (maxima < calificacion.Value.nota) { maxima = calificacion.Value.nota; }
                        if (minima > calificacion.Value.nota) { minima = calificacion.Value.nota; }
                    }
                }
                media = media / count;
                lblMedia.Text = media.ToString();
                lblMaxima.Text = maxima.ToString();
                lblMinima.Text = minima.ToString();
            }
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
