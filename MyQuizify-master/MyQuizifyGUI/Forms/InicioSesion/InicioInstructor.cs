using MyQuizifyLib.BussinessLogic.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms.InicioSesion
{
    public partial class InicioInstructor : Form
    {
        Aplicacion app;
        public InicioInstructor(Aplicacion app)
        {
            this.app = app;
            InitializeComponent();
        }
        private void abrirFormHijo(object formHijo)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }
            Form formularioHijo = formHijo as Form;
            formularioHijo.TopMost = true;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Width = panelContenedor.Width;
            formularioHijo.Height = panelContenedor.Height;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cambiarColorBotones(botonGestionQuiz.Name);
            abrirFormHijo(new QuizesActivos(app)) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cambiarColorBotones(button3.Name);
            abrirFormHijo(new CursosInstructor());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cambiarColorBotones(button4.Name);
            abrirFormHijo(new CreacionDeQuizes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cambiarColorBotones(button2.Name);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            cambiarColorBotones(button1.Name);
            abrirFormHijo(new CrearPreguntasBaterias());
        }

        private void cambiarColorBotones(string nombreBoton)
        {
            ControlCollection objetosDelFormulario = (ControlCollection)Controls;

            foreach (Control c in objetosDelFormulario)
            {
                if (c is Panel)
                {
                    foreach (Control p in c.Controls)
                    {
                        if (p.GetType() == typeof(Button))
                        {
                            Button boton = (Button)p;
                            if (p.Name == nombreBoton)
                            {
                                boton.BackColor = Color.MediumPurple;
                                boton.ForeColor = Color.White;
                            }
                            else
                            {
                                boton.BackColor = Color.SlateBlue;
                                boton.ForeColor = Color.Black;
                            }
                        }
                    }
                }
            }

        }
    }
}
