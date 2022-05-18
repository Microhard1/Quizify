using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public interface EstrategiaInforme
    {
        void generarInforme(List<Calificacion> calificaciones, Quiz q);
    }
}
