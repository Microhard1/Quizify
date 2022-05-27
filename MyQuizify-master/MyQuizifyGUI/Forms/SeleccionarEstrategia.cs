using MyQuizifyLib.BussinessLogic.Entidades;
using System;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class SeleccionarEstrategia : Form
    {
        Quiz quiz;
        public SeleccionarEstrategia(Quiz q)
        {
            quiz = q;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quiz.SetEstrategia(new EstrategiaPDF());
            quiz.obtenerCalificaciones();
            MessageBox.Show("Informe generado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quiz.SetEstrategia(new EstrategiaTXT());
            quiz.obtenerCalificaciones();
            MessageBox.Show("Informe generado correctamente");
        }
    }
}
