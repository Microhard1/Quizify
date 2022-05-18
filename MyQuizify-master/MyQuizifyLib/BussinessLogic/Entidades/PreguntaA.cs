using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class PreguntaA : Pregunta
    {
        public PreguntaA(string id, string enunciado, string imagen, double puntuacion, string explicacion) :
                base(id, enunciado, imagen, puntuacion, explicacion)
        {

        }

        public override Respuesta crearRespuesta(string enunciado)
        {
            Respuesta r = new RespuestaA(enunciado);
            return r;
        }
    }
}
