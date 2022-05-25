using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Terminado : EstadoQuiz
    {
        protected Quiz quiz;
        public Terminado()
        {

        }
        public override void establecerContexto(Quiz quiz)
        {
            this.quiz = quiz;
        }
        public override void borrarPregunta(Pregunta p)
        {

        }
        public override void añadirPregunta(string id, string enunciado, string imagen,
            double puntuacion, string explicacion)
        {

        }
    }
}
