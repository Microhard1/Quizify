using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Respuesta
    {
        public string enunciado;
        public Respuesta(string enunciado)
        {
            this.enunciado = enunciado;

        }
        public abstract void inicialize(bool correcta);
        public override string ToString()
        {
            return this.enunciado;
        }
    }
}
