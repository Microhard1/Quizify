using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class CrearBateria : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        Dictionary<string, PreguntaMO> preguntasMO;
        Dictionary<string, PreguntaVF> preguntasVF;
        Dictionary<string, PreguntaA> preguntasA;
        List<string> nombrePreguntas;
        Aplicacion app;
        Fachada fachada;
        public CrearBateria(Aplicacion app)
        {
            InitializeComponent();
            preguntasMO = services.obtenerPreguntasMO();
            preguntasVF = services.obtenerPreguntasVF();
            preguntasA = services.obtenerPreguntasA();
            this.app = app;
            fachada = new Fachada();
            nombrePreguntas = new List<string>();
        }

        private void CrearPregunta_Load(object sender, EventArgs e)
        {


        }
        void cargarDatosMO(Dictionary<string, PreguntaMO> data)
        {

            dataGridPreguntas.Rows.Clear();

            foreach (var item in data)
            {
                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }
        void cargarDatosA(Dictionary<string, PreguntaA> data)
        {
            dataGridPreguntas.Rows.Clear();
            if (data.Count() != 0)
            {
                foreach (var item in data)
                {
                    dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                        item.Value.puntuacion, item.Value.explicacion);
                }
            }
        }

        void cargarDatosVF(Dictionary<string, PreguntaVF> data)
        {

            dataGridPreguntas.Rows.Clear();

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "MultiOpcion") cargarDatosMO(preguntasMO);
            if (comboBox1.Text == "Abierta") cargarDatosA(preguntasA);
            if (comboBox1.Text == "Verdadero/Falso") cargarDatosVF(preguntasVF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int counter = 0;
            if (comprobarCampos())
            {
                bool isChecked = false;
                for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
                {
                    string nombrePregunta = dataGridPreguntas.Rows[i].Cells[1].Value.ToString();
                    isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                    if (isChecked)
                    {
                        nombrePreguntas.Add(nombrePregunta);
                    }
                }
                if (counter > 3)
                {
                    fachada.crearBateria(textBoxNombreBateria.Text, comboBox1.Text, nombrePreguntas);
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private bool comprobarCampos()
        {
            int counter = 0;
            if (comboBox1.Text == "" || textBoxNombreBateria.Text == "")
            {
                MessageBox.Show("Debe completar los campos");
                return false;
            }
            else
            {
                bool isChecked = false;
                for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
                {
                    isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                    if (isChecked)
                    {
                        counter++;
                    }
                }
                if (counter < 4) { MessageBox.Show("La bateria debe tener al menos 4 preguntas"); }

            }
            return true;
        }

    }
}
