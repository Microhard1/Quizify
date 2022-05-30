using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class Fachada
    {
        protected Quiz quiz;
        protected Usuario usuario;
        private MyQuizifyServices servicios;
        public Fachada()
        {
            servicios = new MyQuizifyServices();
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

        public void crearBateria(string nombreBateria, string tipo, List<string> preguntasID)
        {
            ArrayList preguntasBateria = new ArrayList();
            
            switch (tipo)
            {
                case "MultiOpcion":
                    foreach (string s in preguntasID)
                        preguntasBateria.Add(servicios.getPreguntaMOById(s));
                    Bateria bateriaMO = new BateriaMultiOpcion(nombreBateria, preguntasBateria);
                    break;

                case "Abierta":
                    foreach (string s in preguntasID)
                        preguntasBateria.Add(servicios.getPreguntaMOById(s));
                    Bateria bateriaA = new BateriaAbierta(nombreBateria, preguntasBateria);
                    break;

                case "Verdadero/Falso":
                    foreach (string s in preguntasID)
                        preguntasBateria.Add(servicios.getPreguntaMOById(s));
                    Bateria bateriaVF = new BateriaVerdaderoFalso(nombreBateria, preguntasBateria);
                    break;
            }
        }

        public Quiz creacionDeQuiz(string tipoDeQuiz, List<Pregunta> preguntas, string nombreQuiz, 
            Usuario creadoPor, int duracion, int peso, string dificultad, DateTime inicio, DateTime fin, Curso asignatura)
        {
            Quiz q = null;
            Instructor instructor = servicios.getInstructorById(creadoPor.username);
            if (tipoDeQuiz == "MultiOpcion")
            {
                q = new QuizMO(nombreQuiz, instructor,
                    duracion, peso, dificultad, inicio, fin, asignatura);
            }
            else if (tipoDeQuiz == "Verdadero/Falso")
            {
                q = new QuizVF(nombreQuiz, instructor,
                    duracion, peso, dificultad, inicio, fin, asignatura);
            }
            else if (tipoDeQuiz == "Respuesta Abierta")
            {
                q = new QuizPA(nombreQuiz, instructor,
                    duracion, peso, dificultad, inicio, fin, asignatura);
            }
            AñadirPreguntas(q, preguntas);
            return q;
        }
        private void AñadirPreguntas(Quiz q, List<Pregunta> preguntas)
        {
            double suma = 0.0;
            foreach (Pregunta p in preguntas)
            {
                suma += p.puntuacion;
            }
            foreach (Pregunta p in preguntas)
            {
                p.puntuacion = (preguntas.Count * p.puntuacion) / suma;
                q.estado.añadirPregunta(p.id, p.enunciado, p.imagen, p.puntuacion, p.explicacion);
            }
        }

    }
}
