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
using MyQuizifyLib.Persistencia;
using FireSharp;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using MyQuizifyGUI.Forms;

namespace MyQuizifyGUI
{
    public partial class InicioAlumno : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        private CrearQuiz crearQuizForm;
        public InicioAlumno()
        {
            InitializeComponent();
            crearQuizForm = new CrearQuiz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ancho = this.Width - (navBar.Width*2);
            int alto = this.Height - panel1.Height;
            AlumnoQuizes alumnoQuizes = new AlumnoQuizes(ancho,alto);
            abrirFormHijo(alumnoQuizes);
            cambiarColorBotones(button1.Name);

        }
        private void button3_Click(object sender, EventArgs e)
        {   
            abrirFormHijo(new CursosAlumno());
            cambiarColorBotones(button3.Name);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new EstadisticasAlumno());
            cambiarColorBotones(button2.Name);
        }

        private void abrirFormHijo(object formHijo)
        {
            if (this.panelForms.Controls.Count > 0)
            {
                this.panelForms.Controls.RemoveAt(0);
            }
            Form formularioHijo = formHijo as Form;
            formularioHijo.TopMost = true;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Width = panelForms.Width;
            formularioHijo.Height = panelForms.Height;
            this.panelForms.Controls.Add(formularioHijo);
            this.panelForms.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void cambiarColorBotones(string nombreBoton)
        {
            ControlCollection objetosDelFormulario = (ControlCollection)this.Controls;

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
        private void InicioAlumno_Load(object sender, EventArgs e)
        {

        }


        private void panelForms_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
