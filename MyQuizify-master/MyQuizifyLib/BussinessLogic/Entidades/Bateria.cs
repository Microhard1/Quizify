using MyQuizifyLib.Persistencia;
using System.Collections;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Bateria
    {
        public ArrayList preguntasBateria;
        public string id;
        protected ConexionBD cf = ConexionBD.getInstancia();
        public Bateria(string id, ArrayList preguntasBateria)
        {
            this.id = id;
            this.preguntasBateria = preguntasBateria;
        }


        public virtual int getNumeroPreguntas()
        {
            return 0;
        }

        public virtual List<Pregunta> getPreguntas()
        {
            return null;
        }


    }

}
