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
    public partial class ContestacionQuizesVF : Form
    {
        Quiz quiz;
        int contadorPregunta;
        public ContestacionQuizesVF(Quiz q)
        {
            InitializeComponent();
            quiz = q;
            contadorPregunta = 0;
            botonSiguiente.Enabled = false;
        }

        private void ContestacionQuizesVF_Load(object sender, EventArgs e)
        {

        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            crearPregunta();
        }

        private void crearPregunta()
        {

        }
    }
}
