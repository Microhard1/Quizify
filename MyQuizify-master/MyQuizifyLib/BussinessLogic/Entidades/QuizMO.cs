using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class QuizMO : Quiz
    {
        public QuizMO(string nombreQuiz, Instructor creadoPor, int duracion, int peso, string dificultad,
                DateTime inicio, DateTime fin, Curso asignatura) :
            base(nombreQuiz, creadoPor, duracion, peso, dificultad, inicio, fin, asignatura)
        {
            FirebaseResponse quiz = ConexionBD.getInstancia().client.Set("/Quizes/QuizesMO/" + nombreQuiz, this);

        }

        public override Pregunta crearPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = new PreguntaMO(id, enunciado, imagen, puntuacion, explicacion);
            return p;
        }
    }
}
