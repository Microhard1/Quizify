using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Alumno : Usuario
    {
        ConexionBD cf = ConexionBD.getInstancia();

        public Alumno(string username, string password, string nombre,
                string apellidos, string telefono, string correo, DateTime fechaNacimiento) :
            base(username, password, nombre, apellidos, telefono, correo, fechaNacimiento)
        {

            FirebaseResponse nuevoAlumno = cf.client.Set("Usuarios/Alumnos/" + username, this);
        }



    }


}
