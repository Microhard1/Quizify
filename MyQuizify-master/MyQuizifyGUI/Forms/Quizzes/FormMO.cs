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
    public partial class FormMO : Form
    {
        public FormMO()
        {
            InitializeComponent();
            inputImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormMO_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOpciones_Enter(object sender, EventArgs e)
        {

        }

        private void inputImagen_Click(object sender, EventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
