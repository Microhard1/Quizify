using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;

namespace MyQuizifyLib.Persistencia
{
    public class ConexionBD
    {

        private static ConexionBD instancia;
        public IFirebaseClient client;
        public IFirebaseConfig conexion;
        public Usuario usuarioConectado;
        public ConexionBD()
        {
            //Conexion BDD Santi
            conexion = new FirebaseConfig()
            {
                AuthSecret = "jjboJ9UGeiagEh7FpSOioz9GQXcuQzn0OD5j8YFk",
                BasePath = "https://myquizify-5d818-default-rtdb.firebaseio.com/"
            };
            //Conexion BDD Microhard
            IFirebaseConfig conexionMicrohard = new FirebaseConfig()
            {
                AuthSecret = "G8JyRbxDwLBglP0vwXdm7G0cX1Raa8nXQud4rtgw",
                BasePath = "https://quizify-62e37-default-rtdb.firebaseio.com/"
            };

            client = new FireSharp.FirebaseClient(conexionMicrohard);
        }

        public static ConexionBD getInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionBD();
            }
            return instancia;
        }

    }
}
