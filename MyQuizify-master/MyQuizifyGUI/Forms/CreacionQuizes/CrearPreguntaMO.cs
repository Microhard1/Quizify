using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class CrearPreguntaMO : Form
    {
        public MyQuizifyServices services = new MyQuizifyServices();
        public CrearPreguntaMO()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string enunciado = textBoxEnunciado.Text;
            string explicacion = textBoxExplicacion.Text;
            string id = textBoxNombrePregunta.Text;
            double puntuacion = 1.0;
            Pregunta p = new PreguntaMO(id, enunciado, "", puntuacion, explicacion);
            p.añadirRespuesta(textBox1.Text);
            p.añadirRespuesta(textBox2.Text);
            p.añadirRespuesta(textBox3.Text);
            p.añadirRespuesta(textBox4.Text);

            if (textBox5.Text != "")
            {
                Quiz q = services.getQuizById(textBox5.Text);
                q.añadirPregunta(p.id, p.enunciado, p.imagen, p.puntuacion, p.explicacion);
            }
            MessageBox.Show("Pregunta creada con exito");
            foreach (Control c in Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c is GroupBox)
                    foreach (Control co in c.Controls)
                        if (co is TextBox) co.Text = "";
            }


        }
    }
}
