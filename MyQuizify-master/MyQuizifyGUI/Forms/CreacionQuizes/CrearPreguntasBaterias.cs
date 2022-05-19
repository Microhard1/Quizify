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
    public partial class CrearPreguntasBaterias : Form
    {
        private CrearBateria cb;
        public CrearPreguntasBaterias()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            CrearBateria cb = new CrearBateria();
            cb.TopLevel = false;
            cb.Width = panelForms.Width;
            cb.Height = panelForms.Height;
            panelForms.Controls.Add(cb);
            cb.Show();
        }

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            button3.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
            CrearPreguntaMO p = new CrearPreguntaMO();
            p.TopLevel = false;
            p.Width = panelForms.Width;
            p.Height = panelForms.Height;
            panelForms.Controls.Add(p);
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            CrearPreguntaMO p = new CrearPreguntaMO();
            p.TopLevel = false;
            p.Width = panelForms.Width;
            p.Height = panelForms.Height;
            panelForms.Controls.Add(p);
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            CrearPreguntaVF p = new CrearPreguntaVF();
            p.TopLevel = false;
            p.Width = panelForms.Width;
            p.Height = panelForms.Height;
            panelForms.Controls.Add(p);
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            CrearPreguntaA p = new CrearPreguntaA();
            p.TopLevel = false;
            p.Width = panelForms.Width;
            p.Height = panelForms.Height;
            panelForms.Controls.Add(p);
            p.Show();
        }
    }
}
