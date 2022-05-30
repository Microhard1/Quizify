using EASendMail;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Alumno : Usuario, IObservador
    {
        public ICollection<Quiz> quizesRealizados;
        private MyQuizifyServices services = new MyQuizifyServices();

        public Alumno(string username, string password, string nombre,
                string apellidos, string telefono, string correo, DateTime fechaNacimiento) :
            base(username, password, nombre, apellidos, telefono, correo, fechaNacimiento)
        {
            quizesRealizados = new List<Quiz>();
            FirebaseResponse nuevoAlumno = ConexionBD.getInstancia().client.Set("Usuarios/Alumnos/" + username, this);
        }
        public void actualizar(Quiz q)
        {
            recibirCorreo(q);
        }
    
        public void recibirCorreo(Quiz realizado)
        {
            double nota = services.getNota(realizado, this);
            try
            {
                SmtpMail objetoCorreo = new SmtpMail("TryIt");
                objetoCorreo.From = "quizifynotifications@gmail.com";
                objetoCorreo.To = correo;
                objetoCorreo.Subject = "NOTA " + realizado.nombreQuiz + " publicada";
                objetoCorreo.TextBody = "La nota del examen " + realizado.nombreQuiz + " ha sido Publicada \n" +
                     nombre + " " + apellidos + " ha obtenido una calificacion de " + nota;

                SmtpServer objetoServidor = new SmtpServer("smtp.gmail.com");
                objetoServidor.User = "quizifyNotifications@gmail.com";
                objetoServidor.Password = "quizify1*";
                objetoServidor.Port = 587;
                objetoServidor.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient objetoCliente = new SmtpClient();
                objetoCliente.SendMail(objetoServidor, objetoCorreo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al realizar el envio " + e.Message);
            }

        }


    }


}
