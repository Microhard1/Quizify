using MyQuizifyGUI.Forms;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.Persistencia;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyQuizifyGUI
{
    public partial class InicioAlumno : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        private CrearQuiz crearQuizForm;
        Aplicacion app;
        public InicioAlumno(Aplicacion app)
        {
            InitializeComponent();
            crearQuizForm = new CrearQuiz();
            this.app = app;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ancho = Width - (navBar.Width * 2);
            int alto = Height - panel1.Height;
            AlumnoQuizes alumnoQuizes = new AlumnoQuizes(ancho, alto, app);
            abrirFormHijo(alumnoQuizes);
            cambiarColorBotones(button1.Name);

        }
        private void button3_Click(object sender, EventArgs e)
        {   
            abrirFormHijo(new CursosAlumno(app));
            cambiarColorBotones(button3.Name);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new EstadisticasAlumno());
            cambiarColorBotones(button2.Name);
        }

        private void abrirFormHijo(object formHijo)
        {
            if (panelForms.Controls.Count > 0)
            {
                panelForms.Controls.RemoveAt(0);
            }
            Form formularioHijo = formHijo as Form;
            formularioHijo.TopMost = true;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Width = panelForms.Width;
            formularioHijo.Height = panelForms.Height;
            panelForms.Controls.Add(formularioHijo);
            panelForms.Tag = formularioHijo;
            formularioHijo.Show();
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
