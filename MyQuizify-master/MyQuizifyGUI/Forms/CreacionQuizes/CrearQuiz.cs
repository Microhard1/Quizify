using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI
{
    public partial class CrearQuiz : Form
    {
        MyQuizifyServices services = new MyQuizifyServices();
        ConexionBD cf = ConexionBD.getInstancia();


        public CrearQuiz()
        {
            InitializeComponent();
        }

        void cargarDatosMO(Dictionary<string, PreguntaMO> data)
        {

            dataGridPreguntas.Columns.Clear();
            dataGridPreguntas.Rows.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }
        }

        void cargarDatosA(Dictionary<string, PreguntaA> data)
        {

            dataGridPreguntas.Columns.Clear();
            dataGridPreguntas.Rows.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }
        }

        void cargarDatosVF(Dictionary<string, PreguntaVF> data)
        {

            dataGridPreguntas.Columns.Clear();
            dataGridPreguntas.Rows.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Selecciona";
            dataGridPreguntas.Columns.Add(col1);
            dataGridPreguntas.Columns.Add("nombre", "id");
            dataGridPreguntas.Columns.Add("enunciado", "enunciado");
            dataGridPreguntas.Columns.Add("puntuacion", "puntuacion");
            dataGridPreguntas.Columns.Add("explicacion", "explicacion");

            foreach (var item in data)
            {

                dataGridPreguntas.Rows.Add(false, item.Key, item.Value.enunciado,
                    item.Value.puntuacion, item.Value.explicacion);
            }


        }

        public BateriaMultiOpcion getBateriaMO()
        {
            BateriaMultiOpcion b = null;
            bool isChecked = false;
            for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
            {
                isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                if (isChecked)
                {
                    b = services.getBateriaMOById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                }
            }
            return b;
        }

        private void dataGridPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Bateria getBateria()
        {
            bool isChecked = false;
            for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
            {
                isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                if (isChecked)
                {
                    return services.getBateriaById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                }
            }
            return null;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridPreguntas.Columns.Clear();
            dataGridPreguntas.Rows.Clear();

            Dictionary<string, PreguntaMO> preguntasMO = services.obtenerPreguntasMO();
            Dictionary<string, PreguntaVF> preguntasVF = services.obtenerPreguntasVF();
            Dictionary<string, PreguntaA> preguntasA = services.obtenerPreguntasA();
            string filtro = comboBox1.Text;
            if (filtro == "Baterias")
            {
                List<Bateria> baterias = services.getBaterias();
                dataGridPreguntas.Columns.Clear();
                dataGridPreguntas.Rows.Clear();
                DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
                col1.HeaderText = "Selecciona";
                dataGridPreguntas.Columns.Add(col1);
                dataGridPreguntas.Columns.Add("nombre", "id");
                dataGridPreguntas.Columns.Add("Numero de preguntas", "numero de preguntas");
                foreach (var bat in baterias)
                {
                    dataGridPreguntas.Rows.Add(false, bat.id, bat.getNumeroPreguntas());
                }
            }

            if (filtro == "Preguntas MultiOpcion") { cargarDatosMO(preguntasMO); }
            if (filtro == "Preguntas Verdadero/Falso") { cargarDatosVF(preguntasVF); }
            if (filtro == "Preguntas Abiertas") { cargarDatosA(preguntasA); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool isChecked = false;

            string filtro = comboBox1.Text;
            switch (filtro)
            {
                case "Baterias":
                    int duracion = Int32.Parse(textBoxHoras.Text) * 60 + Int32.Parse(textBoxMinutos.Text);
                    int peso = Int32.Parse(textBoxPeso.Text);

                    Bateria bateria = getBateria();
                    Fachada fachada = new Fachada();

                    fachada.publicarQuizCreadoPorBateria(textBoxNombreQuiz.Text,
                        services.getInstructorById(cf.usuarioConectado.username), "Borrador",
                        duracion, peso, textBoxDificultad.Text,
                        dateTimePicker1.Value, dateTimePicker2.Value,
                        services.getCursoById(comboBoxCurso.Text), bateria);


                    MessageBox.Show("Quiz creado con exito");
                    break;

                    case "Preguntas MultiOpcion":
                        int duracionQuizmo = Int32.Parse(textBoxHoras.Text) * 60 + Int32.Parse(textBoxMinutos.Text);
                        Quiz qmoPregunta = new QuizMO(textBoxNombreQuiz.Text,
                            services.getInstructorById(cf.usuarioConectado.username),
                            duracionQuizmo, Int32.Parse(textBoxPeso.Text), textBoxDificultad.Text,
                            dateTimePicker1.Value, dateTimePicker2.Value,
                            services.getCursoById(comboBoxCurso.Text));

                    for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
                    {
                        isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                        if (isChecked)
                        {
                            PreguntaMO p = services.getPreguntaMOById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                            qmoPregunta.añadirPregunta(p.id, p.enunciado, p.imagen, p.puntuacion, p.explicacion);
                        }
                    }
                    MessageBox.Show("Quiz creado con exito");
                    break;

                    case "Preguntas Verdadero/Falso":
                        int duracionQuizvf = Int32.Parse(textBoxHoras.Text) * 60 + Int32.Parse(textBoxMinutos.Text);
                        Quiz qvfPregunta = new QuizVF(textBoxNombreQuiz.Text,
                            services.getInstructorById(cf.usuarioConectado.username),
                            duracionQuizvf, Int32.Parse(textBoxPeso.Text), textBoxDificultad.Text,
                            dateTimePicker1.Value, dateTimePicker2.Value,
                            services.getCursoById(comboBoxCurso.Text));

                    for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
                    {
                        isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                        if (isChecked)
                        {
                            PreguntaMO p = services.getPreguntaMOById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                            qvfPregunta.añadirPregunta(p.id, p.enunciado, p.imagen, p.puntuacion, p.explicacion);
                        }
                    }
                    MessageBox.Show("Quiz creado con exito");
                    break;

                    case "Preguntas Abiertas":
                        int duracionQuizA = Int32.Parse(textBoxHoras.Text) * 60 + Int32.Parse(textBoxMinutos.Text);
                        Quiz qAPregunta = new QuizVF(textBoxNombreQuiz.Text,
                            services.getInstructorById(cf.usuarioConectado.username),
                            duracionQuizA, Int32.Parse(textBoxPeso.Text), textBoxDificultad.Text,
                            dateTimePicker1.Value, dateTimePicker2.Value,
                            services.getCursoById(comboBoxCurso.Text));

                    for (int i = 0; i < dataGridPreguntas.Rows.Count - 1; i++)
                    {
                        isChecked = (bool)dataGridPreguntas.Rows[i].Cells[0].Value;
                        if (isChecked)
                        {
                            PreguntaMO p = services.getPreguntaMOById(dataGridPreguntas.Rows[i].Cells[1].Value.ToString());
                            qAPregunta.añadirPregunta(p.id, p.enunciado, p.imagen, p.puntuacion, p.explicacion);
                        }
                    }
                    MessageBox.Show("Quiz creado con exito");
                    break;

            }
        }

    }
}

