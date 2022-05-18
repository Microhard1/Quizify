using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyGUI.Forms
{
    public partial class AlumnoQuizes : Form
    {

        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        int tiempo = 53;
        int ancho, alto;
        public AlumnoQuizes(int ancho, int alto)
        {
            InitializeComponent();
            this.ancho = ancho;
            this.alto = alto;
        }

        private void AlumnoQuizes_Load(object sender, EventArgs e)
        {
            dataGridQuizes.Rows.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridQuizes.Columns.Add(col1);

            dataGridQuizes.Columns.Add("nombre", "Nombre");
            dataGridQuizes.Columns.Add("tipo", "Tipo");
            dataGridQuizes.Columns.Add("dificultad", "Dificultad");
            dataGridQuizes.Columns.Add("duracion", "Duracion");
            dataGridQuizes.Columns.Add("fechaDeInicio", "Inicio");
            dataGridQuizes.Columns.Add("fechaFin", "Fin");
            this.Size = new Size(ancho,alto);
            setWidthColumnas();
        }

        public void setWidthColumnas()
        {
            int w = dataGridQuizes.Width / dataGridQuizes.Columns.Count;
            for (int i = 0; i <= dataGridQuizes.Columns.Count - 1; i++)
            {
                // Remove AutoSizing:
                dataGridQuizes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dataGridQuizes.Columns[i].Width = w;
            }
        }
        public void mostrarQuizes()
        {
            dataGridQuizes.Rows.Clear();
            List<Quiz> quizes = services.listaQuizes();
            foreach(var quiz in quizes)
            {
                dataGridQuizes.Rows.Add(false, quiz.nombreQuiz, quiz.GetType().Name, quiz.dificultad, quiz.duracion,
                    quiz.fechaDeInicio, quiz.fechaFin);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            Quiz q = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if(isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    counter++;
                }
            }

            if (counter == 1)
            {
                CaracteristicasPrincipales caracteristicasPrincipales = new CaracteristicasPrincipales(q);
                caracteristicasPrincipales.ShowDialog();
            }
            else MessageBox.Show("Solo puedes realizar un quiz al mismo tiempo." +
                "Escoge tan solo un quiz para realizar");

            

        }

        private void dataGridQuizes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mostrarQuizes();
            Cursor.Current = Cursors.Default;
        }

    }
}
