using MyQuizifyLib.BussinessLogic.Servicios;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{

    public class Aplicacion
    {
        MyQuizifyServices services = new MyQuizifyServices();
        public ICollection<Curso> listadoCursos;
        public ICollection<Alumno> listadoAlumnos;
        public ICollection<Instructor> listadoInstructores;
        public List<Quiz> quizesActivos;
        public ICollection<PreguntaMO> listadoPreguntasMO;
        public ICollection<PreguntaVF> listadoPreguntasVF;
        public ICollection<PreguntaA> listadoPreguntasA;
        public ICollection<Pregunta> listadoPreguntas;
        public Dictionary<Quiz, Calificacion> listadoCalificacionesQuiz;

        public Aplicacion()
        {
            quizesActivos = services.listaQuizes();
            listadoCursos = services.listarCursos();
            listadoCalificacionesQuiz = new Dictionary<Quiz, Calificacion>();
            listadoPreguntas = services.listarPreguntas();
        }






    }
}
