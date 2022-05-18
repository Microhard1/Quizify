using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyGUI.Forms.Quizzes
{
    public partial class Competencias : Form
    {
        List<string> listaComp = new List<string>();
        List<Quiz> listaQuizes;
        MyQuizifyServices servicios = new MyQuizifyServices();
        public Competencias(List<Quiz> q)
        {
            InitializeComponent();
            listaQuizes = q;
            cargarCompetencias();
        }

        private void cargarCompetencias()
        {
            Dictionary<string,Competencia> diccionarioComp= servicios.getListaCompetencias();
            foreach (var c in diccionarioComp)
            {
                listaCompetencias.Items.Add(c.Value.texto);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonCrearCompetencia_Click(object sender, EventArgs e)
        {
            listaComp.Add(textoCompetencia.Text);
            listaCompetencias.Items.Add(textoCompetencia.Text);
            textoCompetencia.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (Quiz q in listaQuizes)
            {
                foreach (object elemento in listaCompetencias.CheckedItems) {
                    q.añadirCompetencia(elemento.ToString());
                }
            }
            foreach (string s in listaComp) {
                new Competencia(s);
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Competencias añadidas");
        }
    }
}
