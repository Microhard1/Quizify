using FireSharp.Response;
using MyQuizifyGUI.Forms;
using MyQuizifyGUI.Forms.InicioSesion;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Windows.Forms;

namespace MyQuizifyGUI
{
    public partial class InicioSesion : Form
    {
        Aplicacion app;
        MyQuizifyServices services = new MyQuizifyServices();
        ConexionBD cf = ConexionBD.getInstancia();
        private InicioAlumno inicioAlumno;
        private InicioInstructor inicioInstructor;
        private string tipoUsuario;

        public InicioSesion()
        {
            InitializeComponent();
            app = new Aplicacion();
            inicioAlumno = new InicioAlumno(app);
            inicioAlumno.WindowState = FormWindowState.Maximized;
            inicioInstructor = new InicioInstructor(app);
            inicioInstructor.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string _usuario;
            string _password;
            int num = comprobarCredenciales();
            if (num == -1)
            {
                MessageBox.Show("Existen campos sin rellenar");
            }
            else if (num == 0)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                _usuario = textBoxUsername.Text;
                _password = textBoxPassword.Text;
                if (contraseñaFormatoCorrecto(_password))
                {

                    if (verificarUsuario(_usuario))
                    {
                        if (validarContraseña(_usuario, _password))
                        {

                            if (buttonAlumno.Checked)
                            {
                                cf.usuarioConectado = services.getAlumnoById(_usuario);
                                inicioAlumno.WindowState = FormWindowState.Maximized;
                                inicioAlumno.Show();
                                Hide();
                            }
                            else
                            {
                                cf.usuarioConectado = services.getInstructorById(_usuario);
                                inicioInstructor.Show();
                                Hide();
                            }
                        }
                        else MessageBox.Show("Contraseña incorrecta");

                    }
                    else MessageBox.Show("El usuario no está registrado");
                }
                else MessageBox.Show("La contraseña debe contener al menos 6 caracteres");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        public int comprobarCredenciales()
        {

            if (textBoxUsername.Text == "" || textBoxPassword.Text == ""
                || !buttonAlumno.Checked && !buttonInstructor.Checked)
            {
                return -1;
            }


            return 1;
        }

        public bool verificarUsuario(string username)
        {
            if (tipoUsuario == "Alumnos")
            {
                Alumno a = services.getAlumnoById(username);
                if (a != null) return true;
            }
            if (tipoUsuario == "Instructores")
            {
                Instructor i = services.getInstructorById(username);
                if (i != null) return true;
            }
            return false;
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Registrar registrarForm = new Registrar();
            registrarForm.ShowDialog();
        }

        public bool validarContraseña(string username, string pass)
        {
            string a = services.getUserPassword(username, tipoUsuario);

            if (Encriptador.GetSHA256(pass).Equals(a)) return true;
            return false;
        }

        public bool contraseñaFormatoCorrecto(string password)
        {

            if (password.Length < 6) return false;
            return true;

        }

        private void buttonAlumno_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = "Alumnos";
        }

        private void buttonInstructor_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = "Instructores";
        }

    }
}
