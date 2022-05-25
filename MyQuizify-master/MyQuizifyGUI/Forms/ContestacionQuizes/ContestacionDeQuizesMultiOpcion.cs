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
using MyQuizifyLib.Persistencia;

namespace MyQuizifyGUI.Forms
{
    public partial class ContestacionDeQuizesMultiOpcion : Form
    {
        Quiz aContestar;
        ICollection<Pregunta> preguntasSinContestar = new List<Pregunta>();
        int contadorPregunta;
        double nota;
        List<RadioButton> valores;
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
            contadorPregunta = 0;
            this.aContestar = q;
            preguntasSinContestar = aContestar.preguntas;
            nota = 0;
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            guardarValores(contadorPregunta);

            foreach (Control c in groupBox1.Controls)
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;

            button2.Enabled = true;
            contadorPregunta++;
            getValorRB(contadorPregunta);
            if (contadorPregunta + 1 == aContestar.preguntas.Count)
            {
                button1.Enabled = false;
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

        private void button2_Click_1(object sender, EventArgs e)
        {

            contadorPregunta--;
            button1.Enabled = true;
            if (contadorPregunta == 0) button2.Enabled = false;
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            getValorRB(contadorPregunta);
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aContestar.añadirObservador(servicios.getAlumnoById(ConexionBD.getInstancia().usuarioConectado.username));
            Calificacion c = new Calificacion(nota, (QuizMO)aContestar, servicios.getAlumnoById(ConexionBD.getInstancia().usuarioConectado.username));
            FireSharp.Response.FirebaseResponse eliminar = ConexionBD.getInstancia().client.Delete
                ("Calificaciones/" + aContestar.nombreQuiz + "/" + servicios.getAlumnoById(ConexionBD.getInstancia().usuarioConectado.username).username + "/quizRealizado/preguntas");
            MessageBox.Show("Enviado");
            this.Close();
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

        private void ContestacionDeQuizesMultiOpcion_Load(object sender, EventArgs e)
        {

        }

        private void BotonAnt_Click(object sender, EventArgs e)
        {
            contadorPregunta--;
            BotonSig.Enabled = true;
            if (contadorPregunta == 0) BotonAnt.Enabled = false;
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            getValorRB(contadorPregunta);
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }

        private void BotonSig_Click(object sender, EventArgs e)
        {
            guardarValores(contadorPregunta);

            foreach (Control c in groupBox1.Controls)
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;

            BotonAnt.Enabled = true;
            contadorPregunta++;
            if (contadorPregunta + 1 == aContestar.preguntas.Count)
            {
                BotonSig.Enabled = false;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TiempoQuiz_Click(object sender, EventArgs e)
        {

        }
    }
}