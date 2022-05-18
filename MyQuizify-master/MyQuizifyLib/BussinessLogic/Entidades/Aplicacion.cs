using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    
    public class Aplicacion
    {
        MyQuizifyServices services = new MyQuizifyServices();
        public ICollection<Curso> listadoCursos;
        public ICollection<Alumno> listadoAlumnos;
        public ICollection<Instructor> listadoInstructores;
        public ICollection<QuizMO> listadoQuizesMO;
        public ICollection<QuizPA> listadoQuizesPA;
        public ICollection<QuizVF> listadoQuizesVF;
        public ICollection<PreguntaMO> listadoPreguntasMO;
        public ICollection<PreguntaVF> listadoPreguntasVF;
        public ICollection<PreguntaA> listadoPreguntasA;

        public Aplicacion()
        {
            this.listadoCursos = services.listarCursos();
        }






    }
}
