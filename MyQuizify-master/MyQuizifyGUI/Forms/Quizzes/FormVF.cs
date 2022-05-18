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
    public partial class FormVF : Form
    {
        public FormVF()
        {
            InitializeComponent();
            inputImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg;)|*.jpg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                inputImagen.Image = new Bitmap(open.FileName);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormVF_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelFalso_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelFalso_Click(object sender, PaintEventArgs e)
        {
            panelFalso.BackColor = Color.Aqua;
        }

        private void botonAñadirPregunta_Click(object sender, EventArgs e)
        {

        }

        private void inputImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
