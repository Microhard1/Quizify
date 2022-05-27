using FireSharp.Response;
using System;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class QuizPA : Quiz
    {

        public QuizPA(string nombreQuiz, Instructor creadoPor, string estado, int duracion, int peso, string dificultad,
                DateTime inicio, DateTime fin, Curso asignatura) :
            base(nombreQuiz, creadoPor, estado, duracion, peso, dificultad, inicio, fin, asignatura)
        {
            FirebaseResponse res = cf.client.Set("/Quizes/QuizesPA/" + nombreQuiz, this);
        }
        public override Pregunta crearPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = new PreguntaA(id, enunciado, imagen, puntuacion, explicacion);
            return p;
        }
    }
}
