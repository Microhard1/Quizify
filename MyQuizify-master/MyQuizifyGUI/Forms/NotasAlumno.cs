using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class NotasAlumno : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        public NotasAlumno()
        {
            InitializeComponent();
        }

        private void NotasAlumno_Load(object sender, EventArgs e)
        {
            dataGridNotasAlumno.Columns.Add("quiz", "Quiz");
            dataGridNotasAlumno.Columns.Add("asignatura", "Asignatura");
            dataGridNotasAlumno.Columns.Add("nota", "Nota");
            //mostrarNotas();
        }
        /*
        public void mostrarNotas()
        {
            Dictionary<string, Calificacion> diccionarioCalificacion = services.getDiccionarioCalificacion();

            foreach (var q in diccionarioCalificacion)
            {
                if (q.Value.examinado.username == cf.usuarioConectado.username)
                {
                    dataGridNotasAlumno.Rows.Add( q.Value.quizRealizado.nombreQuiz, q.Value.quizRealizado.asignatura.nombre, q.Value.nota);
                }
            }
        }*/

        private void btbVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
