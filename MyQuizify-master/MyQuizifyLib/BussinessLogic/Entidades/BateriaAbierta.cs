using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQuizifyLib.Persistencia;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using System.Collections;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class BateriaAbierta : Bateria
    {
        public BateriaAbierta(string id, ArrayList preguntasBateria) : base(id, preguntasBateria)
        {
            this.preguntasBateria = preguntasBateria;
            FirebaseResponse subirBateria = cf.client.Set("Baterias/Abiertas/" + id, this);
        }
        override public int getNumeroPreguntas()
        {
            int num = preguntasBateria.Count;
            return num;
        }
        override public List<Pregunta> getPreguntas()
        {
            List<Pregunta> listaPreguntas = new List<Pregunta>();
            foreach (PreguntaA p in preguntasBateria)
            {
                listaPreguntas.Add(p);
            }
            return listaPreguntas;
        }
    }
}
