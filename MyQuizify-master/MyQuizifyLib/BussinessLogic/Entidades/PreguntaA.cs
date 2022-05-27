using MyQuizifyLib.Persistencia;

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
