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
using FireSharp.Response;
using MyQuizifyLib.Persistencia;

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
            this.aEditar = quiz;
            counter = 0;
            aEditar.preguntas = servicios.preguntasDeUnQuiz(aEditar.nombreQuiz);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            FirebaseResponse actualizarPregQuiz =
               ConexionBD.getInstancia().client.Set
               ("PreguntasQuiz/PreguntasMultiOpcion/"+ aEditar.nombreQuiz + "/" + p.id + "/enunciado", textBox1.Text);
            FirebaseResponse actualizarPreg0 =
               ConexionBD.getInstancia().client.Set
               ("Preguntas/PreguntasMultiOpcion/" + p.id + "/enunciado", textBox1.Text);
            FirebaseResponse actualizarPreg1 = 
                ConexionBD.getInstancia().client.Set
                ("Respuestas/RespuestasMultiOpcion/" + p.id + "/" + 0 + "/enunciado", textBox2.Text);
            FirebaseResponse actualizarPreg2 =
                ConexionBD.getInstancia().client.Set
                ("Respuestas/RespuestasMultiOpcion/" + p.id + "/" + 1 + "/enunciado", textBox3.Text);
            FirebaseResponse actualizarPreg3 =
                ConexionBD.getInstancia().client.Set
                ("Respuestas/RespuestasMultiOpcion/" + p.id + "/" + 2 + "/enunciado", textBox4.Text);
            FirebaseResponse actualizarPreg4 =
                ConexionBD.getInstancia().client.Set
                ("Respuestas/RespuestasMultiOpcion/" + p.id + "/" + 3 + "/enunciado", textBox5.Text);

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
