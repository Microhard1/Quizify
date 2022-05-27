using MyQuizifyLib.BussinessLogic.Entidades;
using System;
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
            Cursor.Current = Cursors.WaitCursor;
            string enunciado = textBoxEnunciado.Text;
            string explicacion = textBoxExplicacion.Text;
            string id = textBoxNombre.Text;
            Pregunta p = new PreguntaA(id, enunciado, "", 0, explicacion);

            MessageBox.Show("Pregunta creada con exito");
            Cursor.Current = Cursors.Default;
        }
    }
}
