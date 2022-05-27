using System;
using System.Drawing;
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
            botonVerdadero.Checked = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            botonFalso.Checked = false;
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
    }
}
