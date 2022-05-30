using FireSharp.Response;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms.EdicionDePreguntas
{
    public partial class EditarPreguntasMO : Form
    {
        private int counter;
        private Quiz aEditar;
        private Pregunta p;
        private MyQuizifyServices servicios;
        public EditarPreguntasMO(Quiz quiz)
        {
            p = null;
            servicios = new MyQuizifyServices();
            aEditar = quiz;
            counter = 0;
            aEditar.preguntas = servicios.preguntasDeUnQuiz(aEditar.nombreQuiz);
            InitializeComponent();
        }

        private void EditarPreguntasMO_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
            if (counter + 1 == aEditar.preguntas.Count) button1.Enabled = false;
            p = aEditar.preguntas.ToArray<Pregunta>()[counter];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            textBox1.Text = p.enunciado;
            textBox2.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            textBox3.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            textBox4.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            textBox5.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            servicios.actualizarPregunta(p, aEditar, textBox1.Text, textBox2.Text,
                textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show("Pregunta actualizada con exito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter == aEditar.preguntas.Count)
            {
                button1.Enabled = false;
            }
            p = aEditar.preguntas.ToArray<Pregunta>()[counter];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            textBox1.Text = p.enunciado;
            textBox2.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            textBox3.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            textBox4.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            textBox5.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0) button2.Enabled = false;
            p = aEditar.preguntas.ToArray<Pregunta>()[counter];
            p.respuestas = servicios.respuestasDeUnaPregunta(p.id);
            textBox1.Text = p.enunciado;
            textBox2.Text = p.respuestas.ToArray<Respuesta>()[0].enunciado;
            textBox3.Text = p.respuestas.ToArray<Respuesta>()[1].enunciado;
            textBox4.Text = p.respuestas.ToArray<Respuesta>()[2].enunciado;
            textBox5.Text = p.respuestas.ToArray<Respuesta>()[3].enunciado;
        }
    }
}
