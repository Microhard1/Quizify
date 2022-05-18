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

namespace MyQuizifyGUI.Forms
{
    public partial class ContestacionDeQuizesMultiOpcion : Form
    {
        Quiz aContestar;
        int contadorPregunta;
        MyQuizifyServices servicios = new MyQuizifyServices();
        public ContestacionDeQuizesMultiOpcion(Quiz q)
        {
            InitializeComponent();
            contadorPregunta = 0;
            this.aContestar = q;
            aContestar.preguntas = servicios.preguntasDeUnQuiz(aContestar.nombreQuiz);
            labelP1.AutoSize = false;
            
        }

        private void ContestacionDeQuizesMultiOpcion_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorPregunta--;
            button1.Enabled = true;
            if (contadorPregunta == 0) button2.Enabled = false;
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            contadorPregunta++;
            if (contadorPregunta + 1 == aContestar.preguntas.Count) button1.Enabled = false;
            Pregunta p = aContestar.preguntas.ToArray<Pregunta>()[contadorPregunta];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            labelEnunciado.Text = p.enunciado;
            labelP1.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            labelP2.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            labelP3.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            labelP4.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }

        private void labelP4_Click(object sender, EventArgs e)
        {

        }

        private void labelEnunciado_Click(object sender, EventArgs e)
        {

        }
    }
}
