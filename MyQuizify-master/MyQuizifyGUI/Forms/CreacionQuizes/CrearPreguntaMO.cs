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
using MyQuizifyLib.BussinessLogic.Servicios;

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
        }

        private void CrearPreguntaMO_Load(object sender, EventArgs e)
        {

        }
    }
}
