using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace MyQuizifyLib.BussinessLogic.Servicios
{
    public class MyQuizifyServices : IServices
    {
        public MyQuizifyServices()
        {

        }

        ConexionBD cf = ConexionBD.getInstancia();

        public Dictionary<string, PreguntaMO> obtenerPreguntasMO()
        {
            FirebaseResponse preguntasDB = cf.client.Get(@"Preguntas/PreguntasMultiOpcion");
            Dictionary<string, PreguntaMO> datos =
                JsonConvert.DeserializeObject<Dictionary<string, PreguntaMO>>(preguntasDB.Body.ToString());
            return datos;
        }
        public Dictionary<string, PreguntaVF> obtenerPreguntasVF()
        {
            FirebaseResponse preguntasDB = cf.client.Get(@"Preguntas/PreguntasVerdaderoFalso");
            Dictionary<string, PreguntaVF> datos =
                JsonConvert.DeserializeObject<Dictionary<string, PreguntaVF>>(preguntasDB.Body.ToString());
            return datos;
        }
        public Dictionary<string, PreguntaA> obtenerPreguntasA()
        {
            FirebaseResponse preguntasDB = cf.client.Get(@"Preguntas/PreguntasAbiertas");
            Dictionary<string, PreguntaA> datos =
                JsonConvert.DeserializeObject<Dictionary<string, PreguntaA>>(preguntasDB.Body.ToString());
            return datos;
        }
        public Dictionary<string, BateriaMultiOpcion> obtenerBateriasMO()
        {
            FirebaseResponse bateriasDB = cf.client.Get(@"Baterias/MultiOpcion/");
            Dictionary<string, BateriaMultiOpcion> datos =
                JsonConvert.DeserializeObject<Dictionary<string, BateriaMultiOpcion>>(bateriasDB.Body.ToString());
            return datos;
        }
        public Dictionary<string, BateriaAbierta> obtenerBateriasA()
        {
            FirebaseResponse bateriasDB = cf.client.Get(@"Baterias/Abiertas/");
            Dictionary<string, BateriaAbierta> datos =
                JsonConvert.DeserializeObject<Dictionary<string, BateriaAbierta>>(bateriasDB.Body.ToString());
            return datos;
        }
        public Dictionary<string, BateriaVerdaderoFalso> obtenerBateriasVF()
        {
            FirebaseResponse bateriasDB = cf.client.Get(@"Baterias/VerdaderoFalso/");
            Dictionary<string, BateriaVerdaderoFalso> datos =
                JsonConvert.DeserializeObject<Dictionary<string, BateriaVerdaderoFalso>>(bateriasDB.Body.ToString());
            return datos;
        }

        public Alumno getAlumnoById(string id)
        {
            FirebaseResponse get = cf.client.Get("Usuarios/Alumnos/" + id);
            Alumno a = get.ResultAs<Alumno>();
            return a;
        }
        public Instructor getInstructorById(string id)
        {
            FirebaseResponse get = cf.client.Get("Usuarios/Instructores/" + id);
            Instructor i = get.ResultAs<Instructor>();
            return i;
        }

        public Quiz getQuizById(string id)
        {
            FirebaseResponse getQuizMO = cf.client.Get("Quizes/QuizesMO/" + id);
            QuizMO qmo = getQuizMO.ResultAs<QuizMO>();
            FirebaseResponse getQuizPA = cf.client.Get("Quizes/QuizesPA/" + id);
            QuizPA qpa = getQuizPA.ResultAs<QuizPA>();
            FirebaseResponse getQuizVF = cf.client.Get("Quizes/QuizesVF/" + id);
            QuizVF qvf = getQuizVF.ResultAs<QuizVF>();

            if (qmo == null)
            {
                if (qpa == null)
                {
                    if (qvf == null)
                    {
                        return null;
                    }
                    else return qvf;
                }
                else return qpa;
            }
            else return qmo;

        }

        public string getTipoQuiz(Quiz q)
        {
            return q.GetType().Name;

        }

        public Curso getCursoById(string id)
        {
            Curso c = cf.client.Get("Cursos/" + id).ResultAs<Curso>();
            return c;
        }

        public List<Curso> listarCursos()
        {
            FirebaseResponse cursos = cf.client.Get(@"Cursos/");
            List<Curso> listaCursos = new List<Curso>();
            Dictionary<string, Curso> dicCursos = JsonConvert.DeserializeObject<Dictionary<string, Curso>>(cursos.Body.ToString());
            foreach (var curso in dicCursos)
            {
                Curso aux = getCursoById(curso.Value.id);
                listaCursos.Add(aux);
            }
            return listaCursos;
        }

        public List<string> nombreQuizes()
        {
            List<Quiz> lista = listaQuizes();
            List<string> res = new List<string>();
            foreach (Quiz q in lista) {
                res.Add(q.nombreQuiz);
            }
            return res;
        }
        public List<Quiz> listaQuizes()
        {
            List<Quiz> quizes = new List<Quiz>();
            FirebaseResponse quizesMO = cf.client.Get(@"Quizes/QuizesMO");
            Dictionary<string, QuizMO> quizesMultiOpcion =
                JsonConvert.DeserializeObject<Dictionary<string, QuizMO>>(quizesMO.Body.ToString());

            foreach (var item in quizesMultiOpcion)
            {
                quizes.Add(getQuizById(item.Value.nombreQuiz));
            }

            FirebaseResponse quizesVF = cf.client.Get(@"Quizes/QuizesVF");
            Dictionary<string, QuizVF> quizesVerdaderoFalso =
                JsonConvert.DeserializeObject<Dictionary<string, QuizVF>>(quizesVF.Body.ToString());

            foreach (var item in quizesVerdaderoFalso)
            {
                quizes.Add(getQuizById(item.Value.nombreQuiz));
            }

            FirebaseResponse quizesPA = cf.client.Get(@"Quizes/QuizesPA");
            Dictionary<string, QuizPA> quizesPreguntaAbierta =
                JsonConvert.DeserializeObject<Dictionary<string, QuizPA>>(quizesPA.Body.ToString());

            foreach (var item in quizesPreguntaAbierta)
            {
                quizes.Add(getQuizById(item.Value.nombreQuiz));
            }

            return quizes;
        }

        public List<Pregunta> preguntasDeUnQuiz(string nombreQuiz)
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            Quiz q = getQuizById(nombreQuiz);
            if (getTipoQuiz(q) == "QuizPA")
            {
                FirebaseResponse preguntasDelQuiz = cf.client.Get(@"Preguntas/PreguntasAbiertas/" + q.nombreQuiz);
                Dictionary<string, PreguntaA> p =
                    JsonConvert.DeserializeObject<Dictionary<string, PreguntaA>>(preguntasDelQuiz.Body.ToString());
                if (p != null)
                {
                    foreach (var preg in p)
                    {
                        preguntas.Add(preg.Value);
                    }
                }

            }
            if (getTipoQuiz(q) == "QuizMO")
            {
                FirebaseResponse preguntasDelQuiz = cf.client.Get(@"Preguntas/PreguntasMultiOpcion/" + q.nombreQuiz);
                Dictionary<string, PreguntaMO> p =
                    JsonConvert.DeserializeObject<Dictionary<string, PreguntaMO>>(preguntasDelQuiz.Body.ToString());
                if (p != null)
                {
                    foreach (var preg in p)
                    {
                        preguntas.Add(preg.Value);
                    }
                }

            }
            if (getTipoQuiz(q) == "QuizVF")
            {
                FirebaseResponse preguntasDelQuiz = cf.client.Get(@"Preguntas/PreguntasVerdaderoFalso/" + q.nombreQuiz);
                Dictionary<string, PreguntaVF> p =
                    JsonConvert.DeserializeObject<Dictionary<string, PreguntaVF>>(preguntasDelQuiz.Body.ToString());
                if (p != null)
                {
                    foreach (var preg in p)
                    {
                        preguntas.Add(preg.Value);
                    }
                }

            }
            return preguntas;
        }

        public string getRespuestaVF(Pregunta p)
        {
            FirebaseResponse res = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + p.id + "/0/");
            return res.Body.ToString();
        }
        public string getRespuestaA(Pregunta p)
        {
            FirebaseResponse res = cf.client.Get("Respuestas/RespuestasAbiertas/" + p.id + "/0/");
            return res.Body.ToString();
        }
        public List<Respuesta> respuestasDeUnaPregunta(string idPregunta)
        {
            List<Respuesta> respuestas = new List<Respuesta>();
            if (getPreguntaMOById(idPregunta) != null)
            {

                FirebaseResponse resp1 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/0");
                Respuesta a = resp1.ResultAs<Respuesta>();
                FirebaseResponse resp2 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/1");
                Respuesta b = resp2.ResultAs<Respuesta>();
                FirebaseResponse resp3 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/2");
                Respuesta c = resp3.ResultAs<Respuesta>();
                FirebaseResponse resp4 = cf.client.Get("Respuestas/RespuestasMultiOpcion/" + idPregunta + "/3");
                Respuesta d = resp4.ResultAs<Respuesta>();
                respuestas.Add(a);
                respuestas.Add(b);
                respuestas.Add(c);
                respuestas.Add(d);
            }
            else if (getPreguntaAById(idPregunta) != null)
            {
                FirebaseResponse resp1 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/0");
                Respuesta a = resp1.ResultAs<Respuesta>();
                FirebaseResponse resp2 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/1");
                Respuesta b = resp2.ResultAs<Respuesta>();
                FirebaseResponse resp3 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/2");
                Respuesta c = resp3.ResultAs<Respuesta>();
                FirebaseResponse resp4 = cf.client.Get("Respuestas/RespuestasAbiertas/" + idPregunta + "/3");
                Respuesta d = resp4.ResultAs<Respuesta>();
                respuestas.Add(a);
                respuestas.Add(b);
                respuestas.Add(c);
                respuestas.Add(d);
            }
            else if (getPreguntaVFById(idPregunta) != null)
            {
                FirebaseResponse resp1 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/0");
                Respuesta a = resp1.ResultAs<Respuesta>();
                FirebaseResponse resp2 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/1");
                Respuesta b = resp2.ResultAs<Respuesta>();
                FirebaseResponse resp3 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/2");
                Respuesta c = resp3.ResultAs<Respuesta>();
                FirebaseResponse resp4 = cf.client.Get("Respuestas/RespuestasVerdaderoFalso/" + idPregunta + "/3");
                Respuesta d = resp4.ResultAs<Respuesta>();
                respuestas.Add(a);
                respuestas.Add(b);
                respuestas.Add(c);
                respuestas.Add(d);
            }

            return respuestas;
        }

        public List<Bateria> getBaterias()
        {
            List<Bateria> baterias = new List<Bateria>();
            FirebaseResponse bateriasMO = cf.client.Get(@"Baterias/MultiOpcion");
            Dictionary<string, BateriaMultiOpcion> diccBatMO =
                JsonConvert.DeserializeObject<Dictionary<string, BateriaMultiOpcion>>(bateriasMO.Body.ToString());
            if (diccBatMO != null)
            {
                foreach (var bat in diccBatMO)
                {
                    baterias.Add(bat.Value);
                }
            }
            FirebaseResponse bateriasA = cf.client.Get(@"Baterias/Abiertas");
            Dictionary<string, BateriaAbierta> diccBatA =
                JsonConvert.DeserializeObject<Dictionary<string, BateriaAbierta>>(bateriasA.Body.ToString());
            if (diccBatA != null)
            {
                foreach (var bat in diccBatA)
                {
                    baterias.Add(bat.Value);
                }
            }
            FirebaseResponse bateriasVF = cf.client.Get(@"Baterias/VerdaderoFalso");
            Dictionary<string, BateriaVerdaderoFalso> diccBatVF =
                JsonConvert.DeserializeObject<Dictionary<string, BateriaVerdaderoFalso>>(bateriasVF.Body.ToString());
            if (diccBatVF != null)
            {
                foreach (var bat in diccBatVF)
                {
                    baterias.Add(bat.Value);
                }
            }
            return baterias;
        }

        public PreguntaMO getPreguntaMOById(string id)
        {
            FirebaseResponse preguntaMO = cf.client.Get("Preguntas/PreguntasMultiOpcion/"+ id);
            PreguntaMO p1 = preguntaMO.ResultAs<PreguntaMO>();
            if (preguntaMO != null) return p1;


            return null;

        }

        public PreguntaA getPreguntaAById(string id)
        {

            FirebaseResponse preguntaPA = cf.client.Get("Preguntas/PreguntasAbiertas/" + id);
            PreguntaA p3 = preguntaPA.ResultAs<PreguntaA>();
            if (preguntaPA != null) return p3;

            return null;

        }

        public PreguntaVF getPreguntaVFById(string id)
        {

            FirebaseResponse preguntaVF = cf.client.Get("Preguntas/PreguntasVerdaderoFalso/" + id);
            PreguntaVF p2 = preguntaVF.ResultAs<PreguntaVF>();
            if (preguntaVF != null) return p2;

            return null;

        }

        public BateriaMultiOpcion getBateriaMOById(string idBateria)
        {
            BateriaMultiOpcion b;
            FirebaseResponse bateria = cf.client.Get("Baterias/MultiOpcion/" + idBateria);
            b = bateria.ResultAs<BateriaMultiOpcion>();
            return b;
        }
        public Dictionary<string, Calificacion> getDiccionarioCalificacion(Quiz q)
        {
            FirebaseResponse calificaciones = cf.client.Get("Calificaciones/" + q.nombreQuiz + "/");
            Dictionary<string, Calificacion> diccionarioCalificacion =
                JsonConvert.DeserializeObject<Dictionary<string, Calificacion>>(calificaciones.Body.ToString());
            return diccionarioCalificacion;
        }
        public Dictionary<string, CalificacionVF> getDiccionarioCalificacionVF(Quiz q)
        {
            FirebaseResponse calificaciones = cf.client.Get("Calificaciones/" + q.nombreQuiz+"/");
            Dictionary<string, CalificacionVF> diccionarioCalificacion =
                JsonConvert.DeserializeObject<Dictionary<string, CalificacionVF>>(calificaciones.Body.ToString());
            return diccionarioCalificacion;
        }
        public Dictionary<string, CalificacionVF> getDiccionarioCalificacionesAlumno()
        {
            
            Dictionary<string, CalificacionVF> diccionarioRespuesta = new Dictionary<string, CalificacionVF>();
            List<string> nombresQuizes = nombreQuizes();
            Dictionary<string, CalificacionVF> diccionarioCalificacion = new Dictionary<string, CalificacionVF>();
            Dictionary<string, CalificacionVF> diccionarioRes = new Dictionary<string, CalificacionVF>();

            foreach (string nombre in nombresQuizes)
            {
                FirebaseResponse calificaciones = cf.client.Get("Calificaciones/"+ nombre+"/");
                diccionarioCalificacion =
                JsonConvert.DeserializeObject<Dictionary<string, CalificacionVF>>(calificaciones.Body.ToString());
            }
            foreach (var calificacion in diccionarioCalificacion)
            {
                if (calificacion.Value.examinado.username == cf.usuarioConectado.username)
                {
                    diccionarioRes.Add(calificacion.Key, calificacion.Value);
                }
            }
                return diccionarioRespuesta;
        }
        public List<Competencia> getListaCompetencias()
        {
            List<Competencia> competencias = new List<Competencia>();
            FirebaseResponse competenciasDicc = cf.client.Get(@"Competencias/");
            Dictionary<string, Competencia> diccionarioCompetencia =
                JsonConvert.DeserializeObject<Dictionary<string, Competencia>>(competenciasDicc.Body.ToString());
            if (diccionarioCompetencia != null) {
                foreach (var competencia in diccionarioCompetencia)
                {
                    competencias.Add(competencia.Value);
                }
                return competencias;
            }
            return null;
        }
        public List<Calificacion> listarCalificaciones(Quiz q)
        {
            List<Calificacion> listaCalificaciones = new List<Calificacion>();

            FirebaseResponse getCalificaciones = ConexionBD.getInstancia().client.Get
                (@"/Calificaciones/" + q.nombreQuiz);
            Dictionary<string, Calificacion> calificacionesQuiz =
                JsonConvert.DeserializeObject<Dictionary<string, Calificacion>>(getCalificaciones.Body.ToString());
            foreach (var c in calificacionesQuiz)
            {
                listaCalificaciones.Add(c.Value);
            }


            return listaCalificaciones;
        }
        public Bateria getBateriaById(string idBateria)
        {
            FirebaseResponse batMO = cf.client.Get("Baterias/MultiOpcion/" + idBateria);
            if (batMO != null) return batMO.ResultAs<BateriaMultiOpcion>();
            FirebaseResponse batA = cf.client.Get("Baterias/Abiertas/" + idBateria);
            if (batMO != null) return batA.ResultAs<BateriaAbierta>();
            FirebaseResponse batVF = cf.client.Get("Baterias/VerdaderoFalso/" + idBateria);
            if (batMO != null) return batVF.ResultAs<BateriaVerdaderoFalso>();
            return null;
        }

        public Competencia getCompetenciaByID(string id)
        {
            FirebaseResponse compes = cf.client.Get(@"Competencias/");
            Dictionary<string, Competencia> competencias =
                JsonConvert.DeserializeObject<Dictionary<string, Competencia>>(compes.Body.ToString());
            foreach(var c in competencias)
            {
                if (c.Value.texto == id) return c.Value;
            }

            return null;
        }

        


    }
}
