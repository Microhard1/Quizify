using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Pregunta
    {

        public ICollection<Respuesta> respuestas;
        public string id;
        public string enunciado;
        public string imagen;
        public double puntuacion;
        public string explicacion;

        public Pregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion)
        {
            this.id = id;
            this.enunciado = enunciado;
            this.explicacion = explicacion;
            this.puntuacion = puntuacion;
            this.imagen = imagen;

            respuestas = new List<Respuesta>();
        }



        public void añadirRespuesta(string enunciado)
        {
            string tipo = "";
            if (GetType().Name == "PreguntaMO") tipo = "RespuestasMultiOpcion";
            if (GetType().Name == "PreguntaA") tipo = "RespuestasAbiertas";
            if (GetType().Name == "PreguntaVF") tipo = "RespuestasVerdaderoFalso";
            Respuesta r = crearRespuesta(enunciado);

            respuestas.Add(r);
            FirebaseResponse addRespuesta = ConexionBD.getInstancia().client.Set("Respuestas/" + tipo + "/" + id, respuestas);
        }

        public abstract Respuesta crearRespuesta(string enunciado);

        public override string ToString()
        {
            return "id: " + id + "\n" +
                "Enunciado: " + enunciado + "\n" +
                "Explicacion: " + explicacion + "\n"
                + "puntuacion: " + puntuacion + "\n";
        }
    }
}
