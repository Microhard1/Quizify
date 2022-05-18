using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Usuario
    {
        public string username;
        public string password;

        public string nombre;
        public string apellidos;

        public string telefono;
        public string correo;
        public DateTime fechaNacimiento;

        public Usuario(string username, string password, string nombre, 
            string apellidos, string telefono, string correo, DateTime fechaNacimiento) {

            this.username = username;
            this.password = password;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.correo = correo;
            this.fechaNacimiento = fechaNacimiento;
        
        }

        public void cambiarContraseña(string contraseñaNueva)
        {

        }

        public void cambiarCorreo(string correoNuevo)
        {

        }


    }
}
