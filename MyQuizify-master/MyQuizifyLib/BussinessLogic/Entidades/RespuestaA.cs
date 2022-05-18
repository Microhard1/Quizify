using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class RespuestaA : Respuesta
    {
        public RespuestaA(string enunciado) : base(enunciado)
        {



        }
        public override void inicialize(bool correcta)
        {
            //No requiere mas argumentos
        }
    }
}
