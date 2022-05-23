using MyQuizifyLib.BussinessLogic.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System.IO;

namespace MyQuizifyGUI.Forms
{
    public partial class ContestacionDeQuizesMultiOpcion : Form
    {
        Quiz quiz;
        ICollection<Pregunta> preguntasSinContestar = new List<Pregunta>();
        MyQuizifyServices servicios = new MyQuizifyServices();
        int progreso = 0;
        int tiempo;
        double puntuacionTotal = 0;
        double puntuacionAlumno = 0;
        ConexionBD cf = ConexionBD.getInstancia();
        List<Respuesta> res = new List<Respuesta>();
        public ContestacionDeQuizesMultiOpcion(Quiz q)
        {
            InitializeComponent();
            quiz = q;
            quiz.preguntas = servicios.preguntasDeUnQuiz(q.nombreQuiz);
            preguntasSinContestar = quiz.preguntas;
            progreso = getProgreso();
            cargarPregunta();
            //inputImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            tiempo = quiz.duracion * 60;
        }

        private int getProgreso()
        {
            return 100 / quiz.preguntas.Count;
        }


        private void TiempoQuiz_Tick(object sender, EventArgs e)
        {

        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {

        }
        private Image getImagen()
        {
            byte[] img = Convert.FromBase64String(preguntasSinContestar.ElementAt(0).imagen);
            MemoryStream ms = new MemoryStream(img);
            if (ms.Length == 0)
            {
                return null;
            }
            return Image.FromStream(ms);
        }
        private void botonPausa_Click(object sender, EventArgs e)
        {

            TiempoQuiz.Enabled = false;
            var result = MessageBox.Show("¿Desea pausar el quiz?", "Pausa",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Quiz quizPausado = new QuizPA(quiz.nombreQuiz + "_PAUSADO", quiz.creadoPor, "Pausado", tiempo / 60,
                    quiz.peso, quiz.dificultad, quiz.fechaDeInicio, quiz.fechaFin, quiz.asignatura);
                foreach (Pregunta p in preguntasSinContestar)
                {
                    quizPausado.añadirPregunta(p.id, p.enunciado, p.imagen, p.puntuacion, p.explicacion);
                }
                var cerrar = MessageBox.Show("El quiz se ha pausado", "Pausa",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                if (cerrar == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                TiempoQuiz.Enabled = true;
            }
        }
        private void cargarPregunta()
        {

            if (preguntasSinContestar.Count > 0)
            {    
                Pregunta p = preguntasSinContestar.ElementAt(0);
                p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
                Peso.Text = p.puntuacion + " puntos";
                string resultado = servicios.getRespuestaA(preguntasSinContestar.ElementAt(0));
                inputImagen.Image = getImagen();
                Enunciado.Text = p.enunciado;

                labelP1.Text=  p.respuestas.ElementAt(0).enunciado;
                labelP2.Text = p.respuestas.ElementAt(1).enunciado;
                labelP3.Text = p.respuestas.ElementAt(2).enunciado;
                labelP4.Text = p.respuestas.ElementAt(3).enunciado;
            }
            else
            {
                double notaFinal = puntuacionAlumno / puntuacionTotal * 10;
                botonSiguiente.Text = "Enviar quiz";
                var result = MessageBox.Show("Enviar test. \n Su nota ha sido un: " + notaFinal, "Envio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    new Calificacion(notaFinal, quiz, servicios.getAlumnoById(cf.usuarioConectado.username));
                    this.Close();
                }
            }

        }
        private bool comprobarRespuesta()
        {
            Pregunta p = preguntasSinContestar.ElementAt(0);
            

            puntuacionTotal += p.puntuacion;
            if (botonA.Checked && labelP1.Text==res.ElementAt(0).enunciado && res.ElementAt(0).correcta)
            {
                puntuacionAlumno += p.puntuacion;
                return true;
            }
            else if (botonB.Checked && labelP2.Text == res.ElementAt(1).enunciado && res.ElementAt(1).correcta)
            {
                puntuacionAlumno += p.puntuacion;
                return true;
            }
            else if(botonC.Checked && labelP3.Text == res.ElementAt(2).enunciado && res.ElementAt(2).correcta)
            {
                puntuacionAlumno += p.puntuacion;
                return true;
            }
            else if(botonD.Checked && labelP4.Text == res.ElementAt(3).enunciado && res.ElementAt(3).correcta)
            {
                puntuacionAlumno += p.puntuacion;
                return true;
            }
            return false;
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(preguntasSinContestar.ElementAt(0).explicacion, "Ayuda",
            MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void botonSiguiente_Click_1(object sender, EventArgs e)
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

        private void labelTiempo_Click(object sender, EventArgs e)
        {

        }

        private void TiempoQuiz_Tick_1(object sender, EventArgs e)
        {
            tiempo--;
            if (tiempo == 0)
            {
                var result = MessageBox.Show("Se acabó el tiempo, su quiz se enviará automáticamente", "Envio",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                string minutos = tiempo / 60 + "";
                string segundos = tiempo % 60 + "";
                labelTiempo.Text = minutos + " : " + segundos;
            }
        }
    }
}
