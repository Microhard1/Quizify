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
    public partial class CrearPreguntaVF : Form
    {
        public CrearPreguntaVF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enunciado = textBoxEnunciado.Text;
            string explicacion = textBoxExplicacion.Text;
            string id = textBoxNombrePregunta.Text;
            Pregunta p = new PreguntaVF(id, enunciado, "", 0, explicacion);
            p.añadirRespuesta(verdaderoFalso());
            MessageBox.Show("Pregunta creada con exito");
        }

        public string verdaderoFalso()
        {
            if (radioButtonFalso.Checked) return "falso";
            if (radioButtonVerdadero.Checked) return "verdadero";
            return "";
        }
    }
}
