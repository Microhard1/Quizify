using MyQuizifyLib.BussinessLogic.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using MyQuizifyLib.Persistencia;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyGUI.Forms.Quizzes
{
    public partial class Clonacion_de_Quizes : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        ConexionBD cf = ConexionBD.getInstancia();
        public Clonacion_de_Quizes()
        {
            InitializeComponent();
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

            FirebaseResponse quizesMO = cf.client.Get(@"Quizes/QuizesMO");
            Dictionary<string, QuizMO> quizesMultiOpcion =
                JsonConvert.DeserializeObject<Dictionary<string, QuizMO>>(quizesMO.Body.ToString());
            if (quizesMultiOpcion != null)
            {
                foreach (var q in quizesMultiOpcion)
                {
                    if (q.Value.creadoPor.username != cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "MultiOpcion", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                    }
                }
            }

            FirebaseResponse quizesA = cf.client.Get(@"Quizes/QuizesPA");
            Dictionary<string, QuizPA> quizesAbiertos =
                JsonConvert.DeserializeObject<Dictionary<string, QuizPA>>(quizesA.Body.ToString());
            if (quizesAbiertos != null)
            {
                foreach (var q in quizesAbiertos)
                {
                    if (q.Value.creadoPor.username != cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "Pregunta Abierta", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                    }
                }
            }

            FirebaseResponse quizesVF = cf.client.Get(@"Quizes/QuizesVF");
            Dictionary<string, QuizVF> quizesVerdaderoFalso =
                JsonConvert.DeserializeObject<Dictionary<string, QuizVF>>(quizesVF.Body.ToString());
            if (quizesVerdaderoFalso != null)
            {
                foreach (var q in quizesVerdaderoFalso)
                {
                    if (q.Value.creadoPor.username != cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "Verdadero/Falso", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado);
                    }
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
            this.Close();
        }
    }
}
