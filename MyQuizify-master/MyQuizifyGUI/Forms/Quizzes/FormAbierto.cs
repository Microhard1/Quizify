using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class FormAbierto : Form
    {
        public FormAbierto()
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
    }
}
