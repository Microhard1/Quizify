using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class FormMO : Form
    {
        public FormMO()
        {
            InitializeComponent();
            inputImagen.SizeMode = PictureBoxSizeMode.StretchImage;
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
        private void ckeckPregunta2_CheckedChanged(object sender, EventArgs e)
        {
            ckeckPregunta1.Checked = false;
            ckeckPregunta3.Checked = false;
            ckeckPregunta4.Checked = false;
        }

        private void ckeckPregunta1_CheckedChanged(object sender, EventArgs e)
        {
            ckeckPregunta2.Checked = false;
            ckeckPregunta3.Checked = false;
            ckeckPregunta4.Checked = false;
        }

        private void ckeckPregunta3_CheckedChanged(object sender, EventArgs e)
        {
            ckeckPregunta1.Checked = false;
            ckeckPregunta2.Checked = false;
            ckeckPregunta4.Checked = false;
        }

        private void ckeckPregunta4_CheckedChanged(object sender, EventArgs e)
        {
            ckeckPregunta1.Checked = false;
            ckeckPregunta2.Checked = false;
            ckeckPregunta3.Checked = false;
        }
    }
}
