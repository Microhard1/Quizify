using FireSharp.Response;
using MyQuizifyLib.Persistencia;

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
