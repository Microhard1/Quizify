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

namespace MyQuizifyGUI.Forms
{
    public partial class CrearPreguntaA : Form
    {
        public CrearPreguntaA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enunciado = textBoxEnunciado.Text;
            string explicacion = textBoxExplicacion.Text;
            string id = textBoxNombre.Text;
            Pregunta p = new PreguntaA(id, enunciado, "", 0, explicacion);
            
            MessageBox.Show("Pregunta creada con exito");
        }
    }
}
