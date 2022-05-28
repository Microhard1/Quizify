using MyQuizifyLib.BussinessLogic.Entidades;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Servicios
{
    public interface IServices
    {

        Alumno getAlumnoById(string id);
        Instructor getInstructorById(string id);
        Quiz getQuizById(string id);
        string getTipoQuiz(Quiz q);
        List<Curso> listarCursos();
        Curso getCursoById(string id);
        PreguntaMO getPreguntaMOById(string id);
        PreguntaA getPreguntaAById(string id);
        PreguntaVF getPreguntaVFById(string id);
        Dictionary<string, PreguntaVF> obtenerPreguntasVF();
        Dictionary<string, PreguntaMO> obtenerPreguntasMO();
        Dictionary<string, PreguntaA> obtenerPreguntasA();
        Dictionary<string, BateriaMultiOpcion> obtenerBateriasMO();
        List<Quiz> listaQuizes();
        List<Pregunta> preguntasDeUnQuiz(string nombreQuiz);
        BateriaMultiOpcion getBateriaMOById(string nombreBat);
        Dictionary<string, CalificacionVF> getDiccionarioCalificacionVF(Quiz q);
        List<Competencia> getListaCompetencias();

        List<Calificacion> listarCalificaciones(Quiz quiz);
        Bateria getBateriaById(string idBateria);

    }
}
