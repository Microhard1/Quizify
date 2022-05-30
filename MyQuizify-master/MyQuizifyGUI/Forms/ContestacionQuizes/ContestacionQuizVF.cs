using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms.ContestacionQuizes
{
    public partial class ContestacionQuizVF : Form
    {
        Quiz quiz;
        Aplicacion app;
        ICollection<Pregunta> preguntasSinContestar = new List<Pregunta>();
        MyQuizifyServices servicios = new MyQuizifyServices();
        ConexionBD cf = ConexionBD.getInstancia();
        int progreso = 0;
        int tiempo;
        double puntuacionTotal = 0;
        double puntuacionAlumno = 0;
        public ContestacionQuizVF(Quiz q, Aplicacion app)
        {
            InitializeComponent();
            quiz = q;
            this.app = app;
            quiz.preguntas = servicios.preguntasDeUnQuiz(q.nombreQuiz);
            preguntasSinContestar = quiz.preguntas;
            progreso = getProgreso();
            cargarPregunta();
            inputImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            tiempo = quiz.duracion * 60;
        }
        private int getProgreso()
        {
            return 100 / quiz.preguntas.Count;
        }
        private void cargarPregunta()
        {
            if (preguntasSinContestar.Count > 0)
            {
                Pregunta p = preguntasSinContestar.ElementAt(0);
                Peso.Text = p.puntuacion + " puntos";
                string res = servicios.getRespuestaVF(preguntasSinContestar.ElementAt(0));
                inputImagen.Image = getImagen();
                Enunciado.Text = p.enunciado;
            }
            else
            {
                double notaFinal = Math.Round(puntuacionAlumno / puntuacionTotal * 10, 2);
                botonSiguiente.Text = "Enviar quiz";
                var result = MessageBox.Show("Enviar test. \n Su nota ha sido un: " + notaFinal, "Envio",
                 MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Calificacion c = new Calificacion(notaFinal, (QuizMO)quiz, servicios.getAlumnoById(cf.usuarioConectado.username));
                    app.listadoCalificacionesQuiz.Add(quiz, c);
                    Close();
                }
            }

        }
        private Image getImagen()
        {
            byte[] img = Convert.FromBase64String(preguntasSinContestar.ElementAt(0).imagen);
            MemoryStream ms = new MemoryStream(img);
            if (ms.Length == 0)
            {
                return Image.FromFile("C:/Users/Usuario/OneDrive/Documentos/upv/software/psw/MyQuizify/MyQuizifyGUI/Forms/ContestacionQuizes/pregunta.jpg");
            }
            return Image.FromStream(ms);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (preguntasSinContestar.Count > 0)
            {
                if (comprobarRespuesta())
                {
                    MessageBox.Show("Respuesta correcta");
                }
                preguntasSinContestar.Remove(preguntasSinContestar.ElementAt(0));
                progressBar1.Value += progreso;
            }
            cargarPregunta();
        }

        private bool comprobarRespuesta()
        {
            Pregunta p = preguntasSinContestar.ElementAt(0);
            string res = servicios.getRespuestaVF(p);
            puntuacionTotal += p.puntuacion;
            if (botonVerdadero.Checked && res.Contains("True"))
            {
                puntuacionAlumno += p.puntuacion;
                return true;
            }
            else if (botonFalso.Checked && res.Contains("False"))
            {
                puntuacionAlumno += p.puntuacion;
                return true;
            }
            return false;
        }

        private void botonPausa_Click(object sender, EventArgs e)
        {

            TiempoQuiz.Enabled = false;
            var result = MessageBox.Show("¿Desea pausar el quiz?", "Pausa",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Quiz quizPausado = new QuizVF(quiz.nombreQuiz+"_PAUSADO", quiz.creadoPor, quiz.peso, tiempo/60,
                               quiz.dificultad, quiz.fechaDeInicio, quiz.fechaFin, quiz.asignatura);
                app.quizesActivos.Add(quizPausado);
                foreach (Pregunta p in preguntasSinContestar)
                {
                    quizPausado.añadirPregunta(p.id, p.enunciado, p.imagen, p.puntuacion, p.explicacion);
                }
                var cerrar = MessageBox.Show("El quiz se ha pausado", "Pausa",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                if (cerrar == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                TiempoQuiz.Enabled = true;
            }
        }

        private void TiempoQuiz_Tick(object sender, EventArgs e)
        {
            tiempo--;
            if (tiempo == 0)
            {
                var result = MessageBox.Show("Se acabó el tiempo, su quiz se enviará automáticamente", "Envio",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                string minutos = tiempo / 60 + "";
                string segundos = tiempo % 60 + "";
                labelTiempo.Text = minutos + " : " + segundos;
            }
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(preguntasSinContestar.ElementAt(0).explicacion, "Ayuda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
        }

        private void ContestacionQuizVF_Load(object sender, EventArgs e)
        {

        }
    }
}
