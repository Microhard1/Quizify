using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class RespuestaVF : Respuesta
    {
        bool correcta;
        public RespuestaVF(string enunciado) : base(enunciado)
        {

        }
        public override void inicialize(bool correcta)
        {
            this.correcta = correcta;
        }
    }
}
