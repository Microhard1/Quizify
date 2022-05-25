using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class EstadoQuiz
    {
        public abstract void establecerContexto(Quiz q);
        public abstract void borrarPregunta(Pregunta pregunta);
        public abstract void añadirPregunta(string id, string enunciado, string imagen,
            double puntuacion, string explicacion);

    }
}
