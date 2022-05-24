using FireSharp.Response;
using MyQuizifyLib.Persistencia;
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
            ConexionBD.getInstancia().client.Set("Preguntas/PreguntasAbiertas/" + this.id + "/", this);
        }

        public override Respuesta crearRespuesta(string enunciado)
        {
            Respuesta r = new RespuestaA(enunciado);
            return r;
        }
    }
}
