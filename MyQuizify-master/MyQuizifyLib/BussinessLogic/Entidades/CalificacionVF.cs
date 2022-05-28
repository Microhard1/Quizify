using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class CalificacionVF
    {
        ConexionBD cf = ConexionBD.getInstancia();

        public double nota;
        public QuizVF quizRealizado;
        public Alumno examinado;

        public DateTime fecha;

        public CalificacionVF(double nota, QuizVF quizRealizado, Alumno examinado)
        {
            this.nota = nota;
            this.quizRealizado = quizRealizado;
            this.examinado = examinado;

            FirebaseResponse nuevaCalificacion =
                cf.client.Set("Calificaciones/" + quizRealizado.nombreQuiz + "/" + examinado.username + "/", this);
        }
    }
}
