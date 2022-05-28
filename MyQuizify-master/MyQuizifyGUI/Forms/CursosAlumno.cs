using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class CursosAlumno : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        Aplicacion app;
        public CursosAlumno(Aplicacion app)
        {
            InitializeComponent();
            dataGridViewCursos.Columns.Add("nombre", "Nombre");
            dataGridViewCursos.Columns.Add("id", "Id");
            this.app = app;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewCursos.Rows.Clear();

            foreach (Curso c in app.listadoCursos)
            {
                dataGridViewCursos.Rows.Add(false, c.nombre, c.id);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
