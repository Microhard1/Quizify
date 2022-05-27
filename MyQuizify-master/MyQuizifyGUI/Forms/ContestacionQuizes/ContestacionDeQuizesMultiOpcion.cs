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
        Quiz aContestar;
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
            aContestar = q;
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
            Calificacion c = new Calificacion(nota, (QuizVF)aContestar, servicios.getAlumnoById(ConexionBD.getInstancia().usuarioConectado.username));
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
    }
}