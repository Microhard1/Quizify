using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class BateriaMultiOpcion : Bateria
    {
        public BateriaMultiOpcion(string id, ArrayList preguntasBateria) : base(id, preguntasBateria)
        {
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/MultiOpcion/" + id, this);
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
                PreguntaMO preg = (PreguntaMO)p;
                listaPreguntas.Add(preg);
            }
            return listaPreguntas;
        }


    }
}
