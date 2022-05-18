using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class RespuestaMO : Respuesta
    {
        public bool correcta;
        public RespuestaMO(string enunciado) : base(enunciado)
        {
            this.correcta = false;
        }
        public override void inicialize(bool correcta)
        {
            this.correcta = correcta;
        }
    }
}
