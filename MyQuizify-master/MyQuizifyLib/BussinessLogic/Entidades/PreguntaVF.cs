using MyQuizifyLib.Persistencia;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class PreguntaVF : Pregunta
    {

        public PreguntaVF(string id, string enunciado, string imagen, double puntuacion, string explicacion) :
            base(id, enunciado, imagen, puntuacion, explicacion)
        {
            ConexionBD.getInstancia().client.Set("Preguntas/PreguntasVerdaderoFalso/" + this.id + "/", this);
        }
        public override Respuesta crearRespuesta(string enunciado)
        {
            Respuesta r = new RespuestaVF(enunciado);
            return r;
        }

    }
}
