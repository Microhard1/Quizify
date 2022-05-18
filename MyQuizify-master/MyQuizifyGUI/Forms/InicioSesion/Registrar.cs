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
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using System.Text.RegularExpressions;
using System.Globalization;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyGUI.Forms
{
    public partial class Registrar : Form
    {
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        Dictionary<string, Alumno> alumnosDictionary = new Dictionary<string, Alumno>();
        string tipoUsuario;
        
        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = textBoxCorreo.Text;
            string contraseña = textBoxPassword.Text;
            bool check = comprobarCampos();
            if (!check) MessageBox.Show("Existen campos sin rellenar");
            else
            {
                if (IsValidEmail(correo))
                {
                    string nombreUsuario = textBoxUsername.Text;
                    if (existeUsuario(nombreUsuario))
                    {
                        MessageBox.Show("Nombre de usuario no disponible");
                    }
                    else
                    {
                        if (contraseñaFormatoCorrecto(contraseña))
                        {
                            bool passwords = comprobarContraseñas();
                            if (!passwords)
                            {
                                MessageBox.Show("Las contraseñas no coinciden");
                            }
                            else
                            {
                                if (botonAlumno.Checked)
                                {
                                    string passwordEncrypted = Encriptador.GetSHA256(textBoxPassword.Text);
                                    Alumno nuevoAlumno = new Alumno(nombreUsuario, passwordEncrypted,
                                    textBoxNombre.Text, textBoxApellidos.Text, textBoxTLF.Text,
                                    textBoxCorreo.Text, dateTimeFechaNac.Value);

                                    MessageBox.Show("Registrado con éxito");
                                    this.Close();


                                }
                                else if (botonInstructor.Checked)
                                {
                                    string passwordEncrypted = Encriptador.GetSHA256(textBoxPassword.Text);
                                    Instructor nuevoAlumno = new Instructor(nombreUsuario, passwordEncrypted,
                                    textBoxNombre.Text, textBoxApellidos.Text, textBoxTLF.Text,
                                    textBoxCorreo.Text, dateTimeFechaNac.Value);

                                    MessageBox.Show("Registrado con éxito");
                                    this.Close();
                                }
                            }
                        }
                        else MessageBox.Show("La contraseña debe contener al menos 6 caracteres");
                    }
                }
                else MessageBox.Show("El formato de correo es incorrecto");
            }

        }

        public bool comprobarCampos() {

            if (textBoxNombre.Text == "" || textBoxApellidos.Text == "" || textBoxCorreo.Text == "" ||
                textBoxTLF.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "" ||
                textBoxCheckPassword.Text == "" || !dateTimeFechaNac.Checked || 
                !botonAlumno.Checked && !botonInstructor.Checked) return false;
            return true;
        }

        public bool comprobarContraseñas() {
            if (!textBoxPassword.Text.Equals(textBoxCheckPassword.Text)) return false;
            return true;
        }

        public bool existeUsuario(string nombreUser)
        {
            if (botonAlumno.Checked)
            {
                Alumno aux = services.getAlumnoById(nombreUser);
                if ( aux == null) return false;
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
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
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
            tipoUsuario = "Alumnos";
        }

        private void botonInstructor_CheckedChanged(object sender, EventArgs e)
        {
            tipoUsuario = "Instructores";
        }

       
    }
}
