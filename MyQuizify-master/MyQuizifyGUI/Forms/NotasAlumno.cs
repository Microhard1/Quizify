using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class NotasAlumno : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        public NotasAlumno()
        {
            InitializeComponent();
        }

        private void NotasAlumno_Load(object sender, EventArgs e)
        {
            dataGridNotasAlumno.Columns.Add("quiz", "Quiz");
            dataGridNotasAlumno.Columns.Add("asignatura", "Asignatura");
            dataGridNotasAlumno.Columns.Add("nota", "Nota");
        }
        private void btbVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
