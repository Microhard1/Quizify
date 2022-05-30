using FireSharp.Response;
using MyQuizifyLib.Persistencia;
using System;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Fachada
    {
        protected Quiz quiz;
        protected Usuario usuario;
        public Fachada()
        {

        }
        public void publicarQuizCreadoPorBateria(string nombreQuiz, Instructor creadoPor,
            string estado, int duracion, int peso, string dificultad, DateTime inicio, DateTime fin,
            Curso asignatura, Bateria bateria)
        {

            if (bateria.GetType().Name == "BateriaMultiOpcion")
            {
                quiz = new QuizMO(nombreQuiz, creadoPor, duracion, peso,
                dificultad, inicio, fin, asignatura);
            }
            if (bateria.GetType().Name == "BateriaVerdaderoFalso")
            {
                quiz = new QuizVF(nombreQuiz, creadoPor, duracion, peso,
                dificultad, inicio, fin, asignatura);
            }
            if (bateria.GetType().Name == "BateriaAbierta")
            {
                quiz = new QuizPA(nombreQuiz, creadoPor, duracion, peso,
                dificultad, inicio, fin, asignatura);

            }

            quiz.cambiarEstado(new Publicado());

            foreach (Pregunta p in bateria.getPreguntas())
            {
                quiz.añadirPregunta(p.id, p.enunciado, p.imagen,
                    p.puntuacion, p.explicacion);
            }

        }

        public void crearUsuario(string tipoUsuario, string username, string contraseña, 
            string nombre, string apellidos, string telefono, string correo, DateTime fechaNacimiento)
        {
            Encriptador encriptador = new Encriptador(contraseña);
            if (tipoUsuario == "Alumno")
                new Alumno(username, encriptador.password, nombre, apellidos, telefono, correo, fechaNacimiento);
            else if (tipoUsuario == "Instructor")
                new Instructor(username, encriptador.password, nombre, apellidos, telefono, correo, fechaNacimiento);
        }

        

    }
}
