using FireSharp.Response;
using MyQuizifyGUI.Forms;
using MyQuizifyGUI.Forms.EdicionDePreguntas;
using MyQuizifyGUI.Forms.Quizzes;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI
{
    public partial class QuizesActivos : Form
    {
        Aplicacion app;
        private CrearQuiz q;
        private Clonacion_de_Quizes clonacionForm;
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        public QuizesActivos(Aplicacion app)
        {
            this.app = app;
            InitializeComponent();
            q = new CrearQuiz();
            clonacionForm = new Clonacion_de_Quizes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q.ShowDialog();
        }

        private void InicioInstructor_Load(object sender, EventArgs e)
        {
            dataGridQuizes.Columns.Add("nombre", "Nombre");
            dataGridQuizes.Columns.Add("tipo", "Tipo");
            dataGridQuizes.Columns.Add("dificultad", "Dificultad");
            dataGridQuizes.Columns.Add("duracion", "Duracion");
            dataGridQuizes.Columns.Add("fechaDeInicio", "Inicio");
            dataGridQuizes.Columns.Add("fechaFin", "Fin");
            dataGridQuizes.Columns.Add("estado", "Estado");


        }
        public string getTipoQuiz(string quiz)
        {
            string tipo = "QuizesMO";
            if (quiz == "Pregunta Abierta") tipo = "QuizesPA";
            else if (quiz == "Verdadero/Falso") tipo = "QuizesVF";
            return tipo;
        }

        public void mostrarQuizes()
        {
            app.quizesActivos = services.listaQuizes();
            foreach (Quiz q in app.quizesActivos)
            {
                if (q.creadoPor.username == cf.usuarioConectado.username)
                {
                    dataGridQuizes.Rows.Add(false, q.nombreQuiz, "MultiOpcion", q.dificultad, q.duracion, q.fechaDeInicio, q.fechaFin, q.estado.GetType().Name);
                }
            }
            
        }

        private void comboBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = comboBoxEstados.Text;
        }

        public void eliminarDatosGrid()
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    dataGridQuizes.Rows.Remove(dataGridQuizes.Rows[i]);
                }
            }
        }

        public void deseleccionarChecks()
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true) dataGridQuizes.Rows[i].Cells[0].Value = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Calificacion> calificacionesQuiz = new List<Calificacion>();
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if(q.nombreQuiz == nombre)
                        {  
                            calificacionesQuiz = services.listarCalificaciones(q);
                            SeleccionarEstrategia sel = new SeleccionarEstrategia(q);
                            sel.ShowDialog();
                            break;
                        }
                    }
                    
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clonacionForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quiz quiz = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    quiz = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                }
            }
            if (quiz != null)
            {
                Estadisticas estadisticas = new Estadisticas(quiz);
                estadisticas.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if (q.nombreQuiz == nombre)
                        {
                            dataGridQuizes.Rows.Remove(dataGridQuizes.Rows[i]);
                            services.borrarQuiz(q);
                        }
                    }


                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if (q.nombreQuiz == nombre && q.estado is Borrador)
                        {
                            q.cambiarEstado(new Publicado());
                            MessageBox.Show("Quiz publicado con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;

                        }
                        else MessageBox.Show("El quiz " + q.nombreQuiz + "con estado : " + q.estado.GetType().Name +
                            ", no se puede publicar ya que no está en estado Borrador");
                    }
                }
            }
            deseleccionarChecks();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if (q.nombreQuiz == nombre && q.estado is Publicado)
                        {
                            q.cambiarEstado(new Borrador());
                            MessageBox.Show("Quiz cancelado con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;
                        }
                        else MessageBox.Show("El quiz " + q.nombreQuiz + " no se puede cancelar ya que no se ha publicado todavia");
                    }
                }
            }
            deseleccionarChecks();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if (!(q.estado is Borrador) && q.nombreQuiz == nombre) MessageBox.Show("El quiz ya ha sido publicado, no puedes editar preguntas");
                        else
                        {
                            EditarPreguntasMO edit = new EditarPreguntasMO(q);
                            edit.ShowDialog();
                        }
                    }
                }
            }
            deseleccionarChecks();
        }

        private void button10_Click(object sender, EventArgs e)
        {
             List<Quiz> listaQuizes = new List<Quiz>();
             for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
             {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if(q.nombreQuiz == nombre)
                        listaQuizes.Add(q);
                    }
                }
             }
             new Competencias(listaQuizes).ShowDialog();
        }

        private void botonCargarQuizzes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridQuizes.Rows.Clear();
            mostrarQuizes();
            Cursor.Current = Cursors.Default;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if (!(q.estado is Terminado) && q.nombreQuiz == nombre) MessageBox.Show("El quiz debe estar en estado Terminado para publicar los resultados");
                        else
                        {
                            q.cambiarEstado(new ResultadosPublicados());
                            q.notificar();
                            MessageBox.Show("Resultados publicados con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;
                        }
                    }
                    

                }
            }
            deseleccionarChecks();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos) { 
                   
                        if (!(q.estado is Publicado) && q.nombreQuiz == nombre) MessageBox.Show("El quiz debe estar en estado Publicado para poder finalizarlo");
                        else
                        {
                            q.cambiarEstado(new Terminado());
                            MessageBox.Show("Terminado con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;
                        }
                    }

                }
            }
            deseleccionarChecks();
        }
    }
}
