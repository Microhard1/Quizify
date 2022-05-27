using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public interface EstrategiaInforme
    {
        void generarInforme(List<Calificacion> calificaciones, Quiz q);
    }
}
