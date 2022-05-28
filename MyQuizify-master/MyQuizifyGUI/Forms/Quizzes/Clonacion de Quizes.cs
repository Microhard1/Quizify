using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms.Quizzes
{
    public partial class Clonacion_de_Quizes : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        ConexionBD cf = ConexionBD.getInstancia();
        Aplicacion app;
        public Clonacion_de_Quizes(Aplicacion app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void Clonacion_de_Quizes_Load(object sender, EventArgs e)
        {
            dataGridQuizes.Rows.Clear();


            dataGridQuizes.Columns.Add("nombre", "Nombre");
            dataGridQuizes.Columns.Add("tipo", "Tipo");
            dataGridQuizes.Columns.Add("dificultad", "Dificultad");
            dataGridQuizes.Columns.Add("duracion", "Duracion");
            dataGridQuizes.Columns.Add("fechaDeInicio", "Inicio");
            dataGridQuizes.Columns.Add("fechaFin", "Fin");
            dataGridQuizes.Columns.Add("estado", "Estado");

            mostrarQuizes();
        }
        public void mostrarQuizes()
        {
            string tipo = "";
            foreach (Quiz q in app.quizesActivos)
            {
                if (q.GetType().Name == "QuizMO") tipo = "MultiOpcion";
                if (q.GetType().Name == "QuizVF") tipo = "Verdadero/Falso";
                if (q.GetType().Name == "QuizPA") tipo = "Preguntas Abiertas";

                if (q.creadoPor.username != cf.usuarioConectado.username)
                {
                    dataGridQuizes.Rows.Add(false, q.nombreQuiz, tipo, q.dificultad, q.duracion, q.fechaDeInicio, q.fechaFin, q.estado);
                }       
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            Quiz q = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    count++;
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    q.clonarQuiz(q);
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Para clonar un quiz primero seleccione uno o varios");
            }
            else if (count == 1)
            {
                MessageBox.Show("Se ha clonado " + count + " Quiz correctamente");
            }
            else
            {
                MessageBox.Show("Se han clonado " + count + " Quizes correctamente");
            }
        }

        private void btbVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
