using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public interface ISujeto
    {
        void notificar();
        void eliminarObservador(IObservador alumno);
        void añadirObservador(IObservador alumno);
    }
}
