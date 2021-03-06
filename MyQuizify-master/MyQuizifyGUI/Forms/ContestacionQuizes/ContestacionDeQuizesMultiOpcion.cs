using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class ContestacionDeQuizesMultiOpcion : Form
    {
        ICollection<Pregunta> preguntasSinContestar = new List<Pregunta>();
        QuizMO aContestar;
        Aplicacion app;
        
        int contadorPregunta;
        double nota;
        int tiempo;

        List<RadioButton> valores;
        Alumno contestador ;
        MyQuizifyServices servicios;
        
        ConexionBD cf = ConexionBD.getInstancia();
        public ContestacionDeQuizesMultiOpcion(Quiz q, Aplicacion app)
        {
            InitializeComponent();
            contadorPregunta = 0;
            nota = 0;
            servicios = new MyQuizifyServices();
            contestador = servicios.getAlumnoById(ConexionBD.getInstancia().usuarioConectado.username);
            aContestar = (QuizMO)q;
            preguntasSinContestar = aContestar.preguntas;
            
            this.app = app;

            aContestar.preguntas = servicios.preguntasDeUnQuiz(aContestar.nombreQuiz);
            valores = new List<RadioButton>(aContestar.preguntas.Count);
            button3.Enabled = false;
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;


            tiempo = q.duracion * 60;
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            Calificacion c = new Calificacion(nota, aContestar, contestador);
            app.listadoCalificacionesQuiz.Add(aContestar, c);
            MessageBox.Show("Enviado");
            Close();
        }

        private void getValorRB(int indice)
        {
            if (valores[indice] != null)
            {
                RadioButton rb = valores[indice];
                {
                    foreach (Control c in groupBox1.Controls)
                        if (c is RadioButton)
                            if (rb.Equals((RadioButton)c))
                                ((RadioButton)c).Checked = true;
                }
            }
        }
        private void guardarValores(int indice)
        {
            RadioButton aux;
            foreach (Control c in groupBox1.Controls)
                if (c is RadioButton)
                    if (((RadioButton)c).Checked)
                    {
                        aux = (RadioButton)c;
                        valores.Insert(indice, aux);
                        break;
                    }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            contadorPregunta--;
            button5.Enabled = true;
            if (contadorPregunta == 0) button4.Enabled = false;
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            getValorRB(contadorPregunta);
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nota += aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta].puntuacion;
            guardarValores(contadorPregunta);

            foreach (Control c in groupBox1.Controls)
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;

            button4.Enabled = true;
            contadorPregunta++;
            
            if (contadorPregunta + 1 == aContestar.preguntas.Count)
            {
                button5.Enabled = false;
                button3.Enabled = true;
            }
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }
       

        private void botonPausa_Click(object sender, EventArgs e)
        {
            TiempoQuiz.Enabled = false;
            var result = MessageBox.Show("¿Desea pausar el quiz?", "Pausa",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Quiz quizPausado = new QuizPA(aContestar.nombreQuiz + "_PAUSADO", aContestar.creadoPor, tiempo / 60,
                    aContestar.peso, aContestar.dificultad, aContestar.fechaDeInicio, aContestar.fechaFin, aContestar.asignatura);
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

    }
}