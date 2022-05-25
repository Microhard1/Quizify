﻿using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Calificacion
    {
        ConexionBD cf = ConexionBD.getInstancia();

        public double nota;
        public QuizMO quizRealizado;
        public Alumno examinado;


        public Calificacion(double nota, QuizMO quizRealizado, Alumno examinado)
        {
            this.nota = nota;
            this.quizRealizado = quizRealizado;
            this.examinado = examinado;

            FirebaseResponse nuevaCalificacion = 
                cf.client.Set("Calificaciones/" + 
                quizRealizado.nombreQuiz + "/" + examinado.username+"/", this);
        }
    }
}
