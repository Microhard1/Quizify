using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
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
    public partial class CursosAlumno : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        public CursosAlumno()
        {
            InitializeComponent();
            dataGridViewCursos.Columns.Add("nombre", "Nombre");
            dataGridViewCursos.Columns.Add("id", "Id");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewCursos.Rows.Clear();
            List<Curso> lista = services.listarCursos();
            foreach (Curso c in lista)
            {
                dataGridViewCursos.Rows.Add(false, c.nombre, c.id);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}