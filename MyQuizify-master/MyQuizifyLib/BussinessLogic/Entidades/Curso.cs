using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Curso
    {
        ConexionBD cf = ConexionBD.getInstancia();
        public ICollection<Instructor> impartidoPor;

        public string id;
        public string nombre;
        public string descripcion;

        public Curso(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

            impartidoPor = new List<Instructor>();

            FirebaseResponse nuevoCurso = cf.client.Set("Cursos/" + id, this);
        }

        public void addInstructor(Instructor p)
        {
            impartidoPor.Add(p);
            FirebaseResponse añadirInstructorACurso = cf.client.Set("ProfesoresCurso/" + id + "/" + p.username, p);
        }






    }
}
