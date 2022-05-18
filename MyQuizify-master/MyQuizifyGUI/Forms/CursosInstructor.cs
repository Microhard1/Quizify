using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;

namespace MyQuizifyGUI.Forms
{
    public partial class CursosInstructor : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        public CursosInstructor()
        {
            InitializeComponent();
        }

        private void PantallaPrincipalInstructor_Load(object sender, EventArgs e)
        {
            dataGridViewCursos.Rows.Clear();

            dataGridViewCursos.Columns.Add("nombre", "Nombre");
            dataGridViewCursos.Columns.Add("id", "Id");

            
            
        }

        public void poblarGrid()
        {
            List<Curso> lista = services.listarCursos();
            foreach (Curso c in lista)
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
                    c.addInstructor(services.getInstructorById(cf.usuarioConectado.username));
                }
            }

            for(int i = 0; i < dataGridViewCursos.Rows.Count - 1; i++)
            {
                dataGridViewCursos.Rows[i].Cells[0].Value = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            poblarGrid();
        }
    }
}
