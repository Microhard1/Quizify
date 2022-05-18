using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;

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

            this.impartidoPor = new List<Instructor>();

            FirebaseResponse nuevoCurso = cf.client.Set("Cursos/" + id ,this);
        }

        public void addInstructor(Instructor p) 
        {
            impartidoPor.Add(p);
            FirebaseResponse añadirInstructorACurso = cf.client.Set("ProfesoresCurso/" + this.id +"/"+ p.username, p);
        }

        




    }
}
