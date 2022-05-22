using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQuizifyLib.Persistencia;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Servicios;

namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Quiz
    {
        protected ConexionBD cf = ConexionBD.getInstancia();
        private MyQuizifyServices services = new MyQuizifyServices();

        public ICollection<Competencia> competencias;
        public ICollection<Pregunta> preguntas;
        public ICollection<Alumno> hechoPor;
        public ICollection<Calificacion> notasQuiz;
        private EstrategiaInforme estrategia;

        public string estado;

        public Curso asignatura;
        public Instructor creadoPor;

        public DateTime fechaDeInicio;
        public DateTime fechaFin;


        public int peso;
        public int duracion;
        public string dificultad;
        public string nombreQuiz;


        public Quiz(string nombreQuiz, Instructor creadoPor, string estado, int duracion, int peso, string dificultad,
                DateTime inicio, DateTime fin, Curso asignatura)
        {
            this.estado = estado;
            this.peso = peso;
            this.nombreQuiz = nombreQuiz;
            this.creadoPor = creadoPor;
            this.duracion = duracion;
            this.dificultad = dificultad;
            this.fechaDeInicio = inicio;
            this.fechaFin = fin;
            this.asignatura = asignatura;

            competencias = new List<Competencia>();
            preguntas = new List<Pregunta>();
            notasQuiz = new List<Calificacion>();
        }



        public void añadirPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion)
        {
            string tipo = "";
            if (this.GetType().Name == "QuizMO") tipo = "PreguntasMultiOpcion";
            if (this.GetType().Name == "QuizVF") tipo = "PreguntasVerdaderoFalso";
            if (this.GetType().Name == "QuizPA") tipo = "PreguntasAbiertas";

            Pregunta p = crearPregunta(id, enunciado, imagen, puntuacion, explicacion);
            this.preguntas.Add(p);
            FirebaseResponse addPregunta = ConexionBD.getInstancia().client.Set("Preguntas/" + tipo + "/" +
               this.nombreQuiz + "/" + p.id, p);
        }

        public abstract Pregunta crearPregunta(string id, string enunciado, string imagen, double puntuacion, string explicacion);


        public void cambiarEstado(string estado)
        {
            string tipoQuiz = "";
            if (this.GetType().Name == "QuizMO") tipoQuiz = "QuizesMO";
            if (this.GetType().Name == "QuizVF") tipoQuiz = "QuizesVF";
            if (this.GetType().Name == "QuizPA") tipoQuiz = "QuizesPA";
            ConexionBD.getInstancia().client.Set("/Quizes/" + tipoQuiz + "/" + nombreQuiz + "/estado", estado);
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

            if (this.GetType().Name == "QuizMO")
            {
                QuizMO quiz = new QuizMO(q.nombreQuiz, a/*q.creadoPor*/, q.estado, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
            else if (this.GetType().Name == "QuizVF")
            {
                QuizVF quiz = new QuizVF(q.nombreQuiz, a/*q.creadoPor*/, q.estado, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.asignatura);
                quiz.preguntas = q.preguntas;
                return quiz;
            }
            else
            {
                QuizPA quiz = new QuizPA(q.nombreQuiz, a/*q.creadoPor*/, q.estado, q.duracion, q.peso, q.dificultad, q.fechaDeInicio, q.fechaFin, q.asignatura);
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
            this.notasQuiz = services.listarCalificaciones(this);
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
                + "estado: " + estado + "\n"
                + "asignatura: " + asignatura + "\n"; 
        }
        public void añadirCompetencias(List<Competencia> compe)
        {
            List<Competencia> auxiliar = new List<Competencia>();
            int counter = 0;
            
            foreach(Competencia c in compe)
            {
                for(int i = 0; i < competencias.Count - 1; i++)
                {
                    if (c.texto.Equals(competencias.ToArray<Competencia>()[i].texto)){
                        counter++;
                        break;
                    }
                }
                if (counter == 0) auxiliar.Add(c);
            }
            FirebaseResponse subirCompetencias = 
                cf.client.Set("CompetenciasQuiz/" + nombreQuiz + "/", auxiliar);       
        }

        /*public void añadirCompetencia(Competencia c)
        {
            cf.client.Set("CompetenciasQuiz/" + nombreQuiz + "/" + c.id, c);
        }*/



    }
}

  
