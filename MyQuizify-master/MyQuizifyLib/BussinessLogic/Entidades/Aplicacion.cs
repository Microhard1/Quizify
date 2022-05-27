﻿using MyQuizifyLib.BussinessLogic.Servicios;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{

    public class Aplicacion
    {
        MyQuizifyServices services = new MyQuizifyServices();
        public ICollection<Curso> listadoCursos;
        public ICollection<Alumno> listadoAlumnos;
        public ICollection<Instructor> listadoInstructores;
        public ICollection<QuizMO> listadoQuizesMO;
        public ICollection<QuizPA> listadoQuizesPA;
        public ICollection<QuizVF> listadoQuizesVF;
        public ICollection<PreguntaMO> listadoPreguntasMO;
        public ICollection<PreguntaVF> listadoPreguntasVF;
        public ICollection<PreguntaA> listadoPreguntasA;

        public Aplicacion()
        {
            listadoCursos = services.listarCursos();
        }






    }
}
