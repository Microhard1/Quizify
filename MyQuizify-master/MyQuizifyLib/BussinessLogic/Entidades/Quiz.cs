using EASendMail;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Quiz : ISujeto
    {
        private MyQuizifyServices services = new MyQuizifyServices();

        public ICollection<Pregunta> preguntas;
        public ICollection<Alumno> hechoPor;
        public ICollection<Calificacion> notasQuiz;
        public ICollection<Competencia> competencias;

        private EstrategiaInforme estrategia;

        public EstadoQuiz estado;

        public Curso asignatura;
        public Instructor creadoPor;

        public DateTime fechaDeInicio;
        public DateTime fechaFin;

        public int peso;
        public int duracion;
        public string dificultad;
        public string nombreQuiz;


        public Quiz(string nombreQuiz, Instructor creadoPor, int duracion, int peso, string dificultad,
                DateTime fechaDeInicio, DateTime fechaFin, Curso asignatura)
        {
            cambiarEstado(new Borrador());
            this.peso = peso;
            this.nombreQuiz = nombreQuiz;
            this.creadoPor = creadoPor;
            this.duracion = duracion;
            this.dificultad = dificultad;
            this.fechaDeInicio = fechaDeInicio;
            this.fechaFin = fechaFin;
            this.asignatura = asignatura;
            preguntas = new List<Pregunta>();
            notasQuiz = new List<Calificacion>();
            competencias = new List<Competencia>();
            hechoPor = new List<Alumno>();

        }



        public void añadirPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion)
        {
            this.estado.añadirPregunta(id, enunciado, imagen, puntuacion, explicacion);
        }

        public void borrarPregunta(Pregunta p)
        {
            this.estado.borrarPregunta(p);
        }
        public abstract Pregunta crearPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion);


        public void cambiarEstado(EstadoQuiz estado)
        {
            this.estado = estado;
            this.estado.establecerContexto(this);
        }

        public bool preguntasRepetidas()
        {
            /* REFACTORING?
            var myArray = preguntasQuiz.ToArray<Pregunta>();
            var longitud = preguntasQuiz.Count;

            for (int i = 0; i < longitud - 1; i++)
            {
                if (myArray[i].enunciado.Equals(myArray[i + 1].enunciado))
                {
                    return true;
                }
            }
            return false;
            */

            for (int i = 0; i < preguntas.Count - 1; i++)
            {
                if (preguntas.ToArray<Pregunta>()[i].enunciado.Equals(preguntas.ToArray<Pregunta>()[i + 1].enunciado))
                {
                    return true;
                }
            }
            return false;
        }
        public void ordenAleatorioPreguntas(Quiz q)
        {
            Random rnd = new Random();
            q.preguntas.OrderBy(item => rnd.Next());
        }
        public Quiz clonarQuiz(Quiz q)
        {
            //eliminar despues de entrega sprint 2
            String nombreUsuario = "a";
            MyQuizifyServices services = new MyQuizifyServices();
            Instructor a = services.getInstructorById(nombreUsuario);
            //eliminar despues de entrega de sprint 2

            if (GetType().Name == "QuizMO")
            {
                QuizMO quiz = new QuizMO(q.nombreQuiz, q.creadoPor, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
            else if (GetType().Name == "QuizVF")
            {
                QuizVF quiz = new QuizVF(q.nombreQuiz, q.creadoPor, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
            else
            {
                QuizPA quiz = new QuizPA(q.nombreQuiz, q.creadoPor, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
        }


        public void SetEstrategia(EstrategiaInforme estrategia)
        {
            this.estrategia = estrategia;
        }

        public void obtenerCalificaciones()
        {
            notasQuiz = services.listarCalificaciones(this);
            estrategia.generarInforme((List<Calificacion>)notasQuiz, this);
        }

        public override string ToString()
        {
            return "Nombre: " + nombreQuiz + "\n" +
                "Creado por: " + creadoPor.username + "\n" +
                "peso: " + peso + "\n"
                + "duracion: " + duracion + "\n"
                + "dificultad: " + dificultad + "\n"
                + "fechaDeInicio: " + fechaDeInicio + "\n"
                + "fechaFin: " + fechaFin + "\n"
                + "estado: " + estado.GetType().Name + "\n"
                + "asignatura: " + asignatura.id + "\n";
        }


        public void añadirCompetencias(List<Competencia> compe)
        {
            List<Competencia> auxiliar = new List<Competencia>();
            int counter = 0;

            foreach (Competencia c in compe)
            {
                for (int i = 0; i < competencias.Count - 1; i++)
                {
                    if (c.texto.Equals(competencias.ToArray<Competencia>()[i].texto))
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0) auxiliar.Add(c);
            }
            FirebaseResponse subirCompetencias =
                ConexionBD.getInstancia().client.Set("CompetenciasQuiz/" + nombreQuiz + "/", auxiliar);
        }


        public void eliminarObservador(IObservador observador)
        {
            hechoPor.Remove(observador as Alumno);
        }
        public void añadirObservador(IObservador observador)
        {
            hechoPor.Add(observador as Alumno);
        }
        public void notificar()
        {
            services.alumnosRealizadoQuiz(this);
            foreach (IObservador a in hechoPor)
            {
                a.actualizar(this);
            }
        }

        public void enviarNotificacion()
        {
            string mensaje = "";
            List<string> mensajes = new List<string>();
            foreach (IObservador observador in hechoPor)
            {
                Alumno aNotificar = (Alumno)observador;
                FirebaseResponse nota = ConexionBD.getInstancia().client.Get("Calificaciones/" + this.nombreQuiz +
                    "/" + aNotificar.username + "/nota");
                double calificacion = nota.ResultAs<double>();
                try
                {
                    SmtpMail objetoCorreo = new SmtpMail("TryIt");
                    objetoCorreo.From = "quizifynotifications@gmail.com";
                    objetoCorreo.To = aNotificar.correo;
                    objetoCorreo.Subject = "NOTA " + this.nombreQuiz + " publicada";
                    objetoCorreo.TextBody = "La nota del examen " + this.nombreQuiz + " ha sido Publicada \n" +
                        aNotificar.nombre + " " + aNotificar.apellidos + " ha obtenido una calificacion de " + calificacion;

                    SmtpServer objetoServidor = new SmtpServer("smtp.gmail.com");
                    objetoServidor.User = "quizifyNotifications@gmail.com";
                    objetoServidor.Password = "quizify1*";
                    objetoServidor.Port = 587;
                    objetoServidor.ConnectType = SmtpConnectType.ConnectSSLAuto;

                    SmtpClient objetoCliente = new SmtpClient();
                    objetoCliente.SendMail(objetoServidor, objetoCorreo);
                    mensaje = "Mensaje enviado correctamente";
                    mensajes.Add(mensaje);
                }
                catch (Exception e)
                {
                    mensaje = "Error al realizar el envio " + e.Message;
                    mensajes.Add(mensaje);
                }
            }
        }
    }
}


