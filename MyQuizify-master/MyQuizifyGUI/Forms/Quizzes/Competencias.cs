using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms.Quizzes
{
    public partial class Competencias : Form
    {
        List<Competencia> listaComp;
        List<Quiz> listaQuizes = new List<Quiz>();

        MyQuizifyServices servicios = new MyQuizifyServices();
        public Competencias(List<Quiz> q)
        {
            InitializeComponent();
            listaQuizes = q;
            listaComp = new List<Competencia>();
        }

        private void cargarCompetencias()
        {
            listaCompetencias.Items.Clear();
            if (listaComp != null)
            {
                foreach (var c in listaComp)
                {
                    listaCompetencias.Items.Add(c.texto);
                }
            }
            else MessageBox.Show("No existen competencias aun");
        }

        private void botonCrearCompetencia_Click(object sender, EventArgs e)
        {
            string id = textboxID.Text;
            string definicion = textBoxDefinicon.Text;
            Competencia c = new Competencia(id, definicion);
            listaComp.Add(c);
            cargarCompetencias();
            textboxID.Clear();
            textBoxDefinicon.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Competencia> aux = new List<Competencia>();
            Cursor.Current = Cursors.WaitCursor;
            foreach (Quiz q in listaQuizes)
            {
                foreach (object item in listaCompetencias.CheckedItems)
                {
                    Competencia c = servicios.getCompetenciaByID(item.ToString());
                    aux.Add(c);
                }
                q.añadirCompetencias(aux);
            }
            Cursor.Current = Cursors.Default;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaComp = servicios.getListaCompetencias();
            cargarCompetencias();
        }

    }
}
