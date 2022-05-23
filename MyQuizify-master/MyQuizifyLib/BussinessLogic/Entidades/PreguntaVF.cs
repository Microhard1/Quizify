using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class PreguntaVF : Pregunta
    {

        public PreguntaVF(string id, string enunciado, string imagen, double puntuacion, string explicacion) :
            base(id, enunciado, imagen, puntuacion, explicacion)
        {
           
        }
        public override Respuesta crearRespuesta(string enunciado)
        {
            Respuesta r = new RespuestaVF(enunciado);
            return r;
        }

    }
}
