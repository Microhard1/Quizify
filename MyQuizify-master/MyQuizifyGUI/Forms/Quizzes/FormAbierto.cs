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
    public partial class FormAbierto : Form
    {
        public FormAbierto()
        {
            InitializeComponent();
            inputImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormAbierto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpeg;)|*.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                inputImagen.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
