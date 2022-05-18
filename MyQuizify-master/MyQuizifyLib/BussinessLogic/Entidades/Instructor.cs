using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;
using MyQuizifyLib.Persistencia;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Instructor : Usuario
    {
        public ICollection<Quiz> quizesCreados;
        public ICollection<Pregunta> preguntasCreadas;
        ConexionBD cf = ConexionBD.getInstancia();
        

        public Instructor(string username, string password, string nombre,
                string apellidos, string telefono, string correo, DateTime fechaNacimiento) : 
            base(username, password, nombre, apellidos, telefono, correo, fechaNacimiento)
        {

            quizesCreados = new List<Quiz>();
            preguntasCreadas = new List<Pregunta>();

            FirebaseResponse nuevoIns = cf.client.Set("Usuarios/Instructores/" + username, this);

        }

        public void addPregunta(Pregunta p)
        {
            preguntasCreadas.Add(p);
        }
        public void addQuiz(Quiz q)
        {
            quizesCreados.Add(q);
        }
    }
}
