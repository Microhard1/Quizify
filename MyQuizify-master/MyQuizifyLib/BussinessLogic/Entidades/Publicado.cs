using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Publicado : EstadoQuiz
    {
        protected Quiz quiz;
        public Publicado()
        {

        }

        public override void establecerContexto(Quiz q)
        {
            this.quiz = q;
        }
        public override void borrarPregunta(Pregunta p)
        {
            foreach (Pregunta pregunta in this.quiz.preguntas)
            {
                if (pregunta.Equals(p))
                {
                    this.quiz.preguntas.Remove(p);
                    string tipo = "";

                    if (this.GetType().Name == "QuizMO") tipo = "PreguntasMultiOpcion";
                    if (this.GetType().Name == "QuizVF") tipo = "PreguntasVerdaderoFalso";
                    if (this.GetType().Name == "QuizPA") tipo = "PreguntasAbiertas";

                    ConexionBD.getInstancia().client.Delete("PreguntasQuiz/" + tipo + "/" +
                    this.quiz.nombreQuiz + "/" + p.id);
                    break;
                }
            }
        }
        public override void añadirPregunta(string id, string enunciado, string imagen,
            double puntuacion, string explicacion)
        {

        }
    }
}