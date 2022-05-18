using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{

    public class Competencia
    {
        public string texto;
        private Quiz quiz;
        ConexionBD cf = ConexionBD.getInstancia();
        public Competencia(string textoComp)
        {
            this.texto = textoComp;
            FirebaseResponse nuevaCompetencia =
                cf.client.Set("Competencias/" + this.texto, this);
        }
    }
}
