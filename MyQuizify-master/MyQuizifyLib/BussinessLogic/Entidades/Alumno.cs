using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Alumno : Usuario, IObservador
    {
        public ICollection<Quiz> quizesRealizados;
        ConexionBD cf = ConexionBD.getInstancia();

        public Alumno(string username, string password, string nombre,
                string apellidos, string telefono, string correo, DateTime fechaNacimiento) :
            base(username, password, nombre, apellidos, telefono, correo, fechaNacimiento)
        {
            quizesRealizados = new List<Quiz>();
            FirebaseResponse nuevoAlumno = cf.client.Set("Usuarios/Alumnos/" + username, this);
        }
        public void actualizar(Quiz q)
        {
            q.enviarNotificacion();
        }



    }


}
