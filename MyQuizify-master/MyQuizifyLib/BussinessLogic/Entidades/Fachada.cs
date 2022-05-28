using System;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Fachada
    {
        protected Quiz quiz;
        public Fachada()
        {

        }
        public void publicarQuizCreadoPorBateria(string nombreQuiz, Instructor creadoPor,
            string estado, int duracion, int peso, string dificultad, DateTime inicio, DateTime fin,
            Curso asignatura, Bateria bateria)
        {

            if (bateria.GetType().Name == "BateriaMultiOpcion")
            {
                quiz = new QuizMO(nombreQuiz, creadoPor, duracion, peso,
                dificultad, inicio, fin, asignatura);
            }
            if (bateria.GetType().Name == "BateriaVerdaderoFalso")
            {
                quiz = new QuizVF(nombreQuiz, creadoPor, duracion, peso,
                dificultad, inicio, fin, asignatura);
            }
            if (bateria.GetType().Name == "BateriaAbierta")
            {
                quiz = new QuizPA(nombreQuiz, creadoPor, duracion, peso,
                dificultad, inicio, fin, asignatura);

            }

            quiz.cambiarEstado(new Publicado());

            foreach (Pregunta p in bateria.getPreguntas())
            {
                quiz.añadirPregunta(p.id, p.enunciado, p.imagen,
                    p.puntuacion, p.explicacion);
            }

        }

    }
}
