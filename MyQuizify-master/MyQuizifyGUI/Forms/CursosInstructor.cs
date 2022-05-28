using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class CursosInstructor : Form
    {
        
        private MyQuizifyServices services = new MyQuizifyServices();
        private Aplicacion app;
        public CursosInstructor(Aplicacion app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void PantallaPrincipalInstructor_Load(object sender, EventArgs e)
        {
            dataGridViewCursos.Rows.Clear();

            dataGridViewCursos.Columns.Add("nombre", "Nombre");
            dataGridViewCursos.Columns.Add("id", "Id");



        }

        public void poblarGrid()
        {
            dataGridViewCursos.Rows.Clear();
            foreach (Curso c in app.listadoCursos)
            {
                dataGridViewCursos.Rows.Add(false, c.nombre, c.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridViewCursos.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridViewCursos.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    Curso c = services.getCursoById(dataGridViewCursos.Rows[i].Cells[2].Value.ToString());
                    c.addInstructor(services.getInstructorById(ConexionBD.getInstancia().usuarioConectado.username));
                }
            }

            for (int i = 0; i < dataGridViewCursos.Rows.Count - 1; i++)
            {
                dataGridViewCursos.Rows[i].Cells[0].Value = false;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            poblarGrid();
        }

        private void botonCrearCompetencia_Click(object sender, EventArgs e)
        {
            string id = textboxID.Text;
            string definicion = textBoxDefinicon.Text;
            Curso c = new Curso(id, definicion);
            dataGridViewCursos.Rows.Add(false, definicion, id);
            textboxID.Clear();
            textBoxDefinicon.Clear();
        }
    }
}
