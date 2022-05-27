using FireSharp.Response;
using System.Collections;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class BateriaVerdaderoFalso : Bateria
    {
        public BateriaVerdaderoFalso(string id, ArrayList preguntasBateria) : base(id, preguntasBateria)
        {
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/VerdaderoFalso/" + id, this);
        }
        override public int getNumeroPreguntas()
        {
            int num = preguntasBateria.Count;
            return num;
        }
        override public List<Pregunta> getPreguntas()
        {
            List<Pregunta> listaPreguntas = new List<Pregunta>();
            foreach (object p in preguntasBateria)
            {
                PreguntaVF preg = (PreguntaVF)p;
                listaPreguntas.Add(preg);
            }
            return listaPreguntas;
        }
    }
}
