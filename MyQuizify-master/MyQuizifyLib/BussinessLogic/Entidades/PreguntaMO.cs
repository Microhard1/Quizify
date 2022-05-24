﻿using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class PreguntaMO : Pregunta
    {
        public PreguntaMO(string id, string enunciado, string imagen, double puntuacion, string explicacion) :
                base(id, enunciado, imagen, puntuacion, explicacion)
        {
            ConexionBD.getInstancia().client.Set("Preguntas/PreguntasMultiOpcion/" + this.id + "/", this);
        }

        public override Respuesta crearRespuesta(string enunciado)
        {
            Respuesta r = new RespuestaMO(enunciado);
            return r;
        }
    }
}
