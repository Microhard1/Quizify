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
        public string id;
        private ConexionBD cf = ConexionBD.getInstancia();
        public Competencia(string id, string texto)
        {
            this.id = id;
            this.texto = texto;
            FirebaseResponse nuevaCompetencia =
                cf.client.Set("Competencias/" + id, this);
        }
    }
}
