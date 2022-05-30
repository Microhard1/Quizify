using FireSharp.Response;
using MyQuizifyGUI.Forms;
using MyQuizifyGUI.Forms.EdicionDePreguntas;
using MyQuizifyGUI.Forms.Quizzes;
using MyQuizifyLib.BussinessLogic.Entidades;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyLib.Persistencia;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyQuizifyGUI
{
    public partial class QuizesActivos : Form
    {
        private Aplicacion app;
        private CrearQuiz q;
        private Clonacion_de_Quizes clonacionForm;
        private MyQuizifyServices services;
        public QuizesActivos(Aplicacion app)
        {
            this.app = app;
            InitializeComponent();
            q = new CrearQuiz();
            services = new MyQuizifyServices();
            clonacionForm = new Clonacion_de_Quizes(app);
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
        
        public void mostrarQuizes()
        {
            string tipoQuiz = "";
            
            app.quizesActivos = services.listaQuizes();
            foreach (Quiz q in app.quizesActivos)
            {

                if (q.GetType().Name == "QuizMO") tipoQuiz = "MultiOpcion";
                if (q.GetType().Name == "QuizVF") tipoQuiz = "Verdadero/Falso";
                if (q.GetType().Name == "QuizPA") tipoQuiz = "Preguntas Abiertas";

                if (q.creadoPor.username == ConexionBD.getInstancia().usuarioConectado.username)
                {
                    dataGridQuizes.Rows.Add(false, q.nombreQuiz, tipoQuiz , q.dificultad, q.duracion, q.fechaDeInicio, q.fechaFin, q.estado.GetType().Name);
                }
            }
            
        }

        private void comboBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = comboBoxEstados.Text;
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
            int comprobador = 0;
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
                            comprobador++;
                            q.cambiarEstado(new Publicado());
                            MessageBox.Show("Quiz publicado con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;
                            break;
                        }
                    }
                    if (comprobador == 0)
                        MessageBox.Show("El quiz no se puede publicar ya que no está en estado Borrador");
                    else comprobador = 0;
                            
                }
            }
            deseleccionarChecks();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int comprobador = 0;
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
                            comprobador++;
                            q.cambiarEstado(new Borrador());
                            MessageBox.Show("Quiz cancelado con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;
                        }
                    }
                    if (comprobador == 0)
                        MessageBox.Show("El quiz no se puede cancelar ya que no está en estado Publicado");
                    else comprobador = 0;
                }
            }
            deseleccionarChecks();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int comprobador = 0;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if (q.estado is Borrador && q.nombreQuiz == nombre)
                        {
                            comprobador++;
                            EditarPreguntasMO edit = new EditarPreguntasMO(q);
                            edit.ShowDialog();
                            break;
                        }
                        
                    }
                    if (comprobador == 0)
                        MessageBox.Show("El quiz ya ha sido publicado, no puedes editar preguntas");
                    else comprobador = 0;
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
            int comprobador = 0;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos)
                    {
                        if (q.estado is Terminado && q.nombreQuiz == nombre)
                        {
                            comprobador++;
                            q.cambiarEstado(new ResultadosPublicados());
                            MessageBox.Show("Resultados publicados con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;
                            break;
                        }
                        
                    }
                    if (comprobador == 0)
                        MessageBox.Show("El quiz debe estar en estado Terminado para publicar los resultados");
                    else comprobador = 0;

                }
            }
            deseleccionarChecks();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int comprobador = 0;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    string nombre = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    foreach (Quiz q in app.quizesActivos) { 
                   
                        if (q.estado is Publicado && q.nombreQuiz == nombre)
                        {
                            comprobador++;
                            q.cambiarEstado(new Terminado());
                            MessageBox.Show("Terminado con éxito");
                            dataGridQuizes.Rows[i].Cells[7].Value = q.estado.GetType().Name;
                            break;
                        }
                        if (comprobador == 0)
                            MessageBox.Show("El quiz debe estar en estado Publicado para poder finalizarlo");
                        else comprobador = 0;
                    }

                }
            }
            deseleccionarChecks();
        }
    }
}
