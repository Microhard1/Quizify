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
    public partial class SeleccionarEstrategia : Form
    {
        Quiz quiz;
        public SeleccionarEstrategia(Quiz q)
        {
            this.quiz = q;
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

        private void SeleccionarEstrategia_Load(object sender, EventArgs e)
        {

        }
    }
}
