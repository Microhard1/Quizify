using MyQuizifyLib.Persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
