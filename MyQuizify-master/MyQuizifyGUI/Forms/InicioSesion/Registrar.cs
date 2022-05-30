using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class Registrar : Form
    {
        MyQuizifyServices services;
        Fachada fachada;
        public string tipoUsuario;

        public Registrar()
        {
            InitializeComponent();
            fachada = new Fachada();
            services = new MyQuizifyServices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!comprobarCampos()) MessageBox.Show("Existen campos sin rellenar");
            else
            {
                string nombreUsuario = textBoxUsername.Text;
                string correo = textBoxCorreo.Text;
                string contraseña = textBoxPassword.Text;
                string nombre = textBoxNombre.Text;
                string apellidos = textBoxApellidos.Text;
                string telefono = textBoxTLF.Text;
                DateTime fechaNac = dateTimeFechaNac.Value;


                if (IsValidEmail(correo))
                {
                    
                    if (existeUsuario(nombreUsuario))
                    {
                        MessageBox.Show("Nombre de usuario no disponible");
                    }
                    else
                    {
                        if (contraseñaFormatoCorrecto(contraseña))
                        {
                            bool contraseñasCorrectas = comprobarContraseñas();
                            if (!contraseñasCorrectas)
                            {
                                MessageBox.Show("Las contraseñas no coinciden");
                            }
                            else
                            {
                                fachada.crearUsuario(tipoUsuario, nombreUsuario, contraseña,
                                    nombre, apellidos, telefono, correo, fechaNac);
                            }
                        }
                        else MessageBox.Show("La contraseña debe contener al menos 6 caracteres");
                    }
                }
                else MessageBox.Show("El formato de correo es incorrecto");
            }

        }

        public bool comprobarCampos()
        {

            if (textBoxNombre.Text == "" || textBoxApellidos.Text == "" || textBoxCorreo.Text == "" ||
                textBoxTLF.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "" ||
                textBoxCheckPassword.Text == "" || !dateTimeFechaNac.Checked ||
                !botonAlumno.Checked && !botonInstructor.Checked) return false;
            return true;
        }

        public bool comprobarContraseñas()
        {
            if (!textBoxPassword.Text.Equals(textBoxCheckPassword.Text)) return false;
            return true;
        }

        public bool existeUsuario(string nombreUser)
        {
            if (botonAlumno.Checked)
            {
                Alumno aux = services.getAlumnoById(nombreUser);
                if (aux == null) return false;
                else return true;
            }
            else
            {
                if (services.getInstructorById(nombreUser) == null) return false;
                else return true;
            }
        }
        public bool contraseñaFormatoCorrecto(string password)
        {

            if (password.Length < 6) return false;
            return true;

        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void botonAlumno_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = botonAlumno.Text;
        }

        private void botonInstructor_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = botonInstructor.Text;
        }


    }
}
