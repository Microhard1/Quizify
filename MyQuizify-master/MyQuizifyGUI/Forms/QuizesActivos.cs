﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyLib.Persistencia;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using MyQuizifyLib.BussinessLogic.Entidades;
using Newtonsoft.Json;
using MyQuizifyLib.BussinessLogic.Servicios;
using MyQuizifyGUI.Forms.Quizzes;
using MyQuizifyGUI.Forms;
using MyQuizifyGUI.Forms.EdicionDePreguntas;

namespace MyQuizifyGUI
{
    public partial class QuizesActivos : Form
    {
        private CrearQuiz q;
        private Clonacion_de_Quizes clonacionForm;
        ConexionBD cf = ConexionBD.getInstancia();
        MyQuizifyServices services = new MyQuizifyServices();
        public QuizesActivos()
        {
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
            dataGridQuizes.Rows.Clear();
                FirebaseResponse quizesMO = cf.client.Get(@"Quizes/QuizesMO");
                Dictionary<string, QuizMO> quizesMultiOpcion =
                    JsonConvert.DeserializeObject<Dictionary<string, QuizMO>>(quizesMO.Body.ToString());
                if (quizesMultiOpcion != null)
                {
                    foreach (var q in quizesMultiOpcion)
                    {
                        if (q.Value.creadoPor.username == cf.usuarioConectado.username)
                        {
                            dataGridQuizes.Rows.Add(false, q.Key, "MultiOpcion", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado.GetType().Name);
                        }
                    }
                }

                FirebaseResponse quizesA = cf.client.Get(@"Quizes/QuizesPA");
                Dictionary<string, QuizPA> quizesAbiertos =
                    JsonConvert.DeserializeObject<Dictionary<string, QuizPA>>(quizesA.Body.ToString());
                if (quizesAbiertos != null)
                {
                    foreach (var q in quizesAbiertos)
                    {
                        if (q.Value.creadoPor.username == cf.usuarioConectado.username)
                        {
                            dataGridQuizes.Rows.Add(false, q.Key, "Pregunta Abierta", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado.GetType().Name);
                        }
                    }
                }

                FirebaseResponse quizesVF = cf.client.Get(@"Quizes/QuizesVF");
                Dictionary<string, QuizVF> quizesVerdaderoFalso =
                    JsonConvert.DeserializeObject<Dictionary<string, QuizVF>>(quizesVF.Body.ToString());
                if (quizesVerdaderoFalso != null)
                {
                    foreach (var q in quizesVerdaderoFalso)
                    {
                        if (q.Value.creadoPor.username == cf.usuarioConectado.username)
                        {
                            dataGridQuizes.Rows.Add(false, q.Key, "Verdadero/Falso", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado.GetType().Name);
                        }
                    }
                }


        }

        public void cambiarEstado(string estadoQuiz)
        {
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true && dataGridQuizes.Rows[i].Cells[1].Value != null)
                {
                    string tipo = services.getTipoQuiz(services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString()));
                    string nombreQuiz = dataGridQuizes.Rows[i].Cells[1].Value.ToString();
                    FirebaseResponse editarEstado =
                        cf.client.Get("/Quizes/" + tipo + "/" + nombreQuiz);

                    if (tipo == "QuizesMO")
                    {

                        Quiz quizMO = editarEstado.ResultAs<QuizMO>();
                        cf.client.Set("Quizes/QuizesMO/" + nombreQuiz + "/", quizMO);
                    }
                    if (tipo == "QuizesPA")
                    {

                        Quiz quizPA = editarEstado.ResultAs<QuizPA>();
                        cf.client.Set("Quizes/QuizesPA/" + nombreQuiz + "/", quizPA);
                    }
                    if (tipo == "QuizesVF")
                    {
                        Quiz quizVF = editarEstado.ResultAs<QuizVF>();
                        cf.client.Set("Quizes/QuizesVF/" + nombreQuiz + "/", quizVF);
                    }

                    dataGridQuizes.Rows[i].Cells[7].Value = estadoQuiz;
                }
            }
        }


        private void comboBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = comboBoxEstados.Text;
            mostrarQuizesFiltrados(estado);
        }

        
        public void mostrarQuizesFiltrados(string filtro)
        {
            dataGridQuizes.Rows.Clear();

            FirebaseResponse borrador = cf.client.Get(@"Estados/Borrador/");
            Dictionary<string, QuizMO> quizesMultiOpcion =
                JsonConvert.DeserializeObject<Dictionary<string, QuizMO>>(borrador.Body.ToString());
            if (quizesMultiOpcion != null)
            {
                foreach (var q in quizesMultiOpcion)
                {
                    if (q.Value.estado.GetType().Name == filtro && q.Value.creadoPor.username == cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "MultiOpcion", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado.GetType().Name);
                    }
                }
            }

            FirebaseResponse quizesA = cf.client.Get(@"Quizes/QuizesPA");
            Dictionary<string, QuizPA> quizesAbiertos =
                JsonConvert.DeserializeObject<Dictionary<string, QuizPA>>(quizesA.Body.ToString());
            if (quizesAbiertos != null)
            {
                foreach (var q in quizesAbiertos)
                {
                    if (q.Value.estado.GetType().Name == filtro && q.Value.creadoPor.username == cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "Pregunta Abierta", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado.GetType().Name);
                    }
                }
            }

            FirebaseResponse quizesVF = cf.client.Get(@"Quizes/QuizesVF");
            Dictionary<string, QuizVF> quizesVerdaderoFalso =
                JsonConvert.DeserializeObject<Dictionary<string, QuizVF>>(quizesVF.Body.ToString());
            if (quizesVerdaderoFalso != null)
            {
                foreach (var q in quizesVerdaderoFalso)
                {
                    if (q.Value.estado.GetType().Name == filtro && q.Value.creadoPor.username == cf.usuarioConectado.username)
                    {
                        dataGridQuizes.Rows.Add(false, q.Key, "Verdadero/Falso", q.Value.dificultad, q.Value.duracion, q.Value.fechaDeInicio, q.Value.fechaFin, q.Value.estado.GetType().Name);
                    }
                }
            }

            
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
            Quiz q = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    calificacionesQuiz = services.listarCalificaciones(q);
                    SeleccionarEstrategia sel = new SeleccionarEstrategia(q);
                    sel.ShowDialog();
                }
            }
        }

        private void dataGridQuizes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clonacionForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quiz q = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                }
            }
            Estadisticas estadisticas = new Estadisticas(q);
            estadisticas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Quiz q = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    dataGridQuizes.Rows.Remove(dataGridQuizes.Rows[i]);
                    string tipo = q.GetType().Name;
                    if (tipo == "QuizMO") {
                        cf.client.Delete("Quizes/QuizesMO/" + q.nombreQuiz);
                        cf.client.Delete("Preguntas/PreguntasMultiOpcion/" + q.nombreQuiz);
                    }
                   
                        
                    else if (tipo == "QuizVF")
                    {
                        cf.client.Delete("Quizes/QuizesVF/" + q.nombreQuiz);
                        cf.client.Delete("Preguntas/PreguntasVerdaderoFalso/" + q.nombreQuiz);
                    }
                        
                        
                    else if (tipo == "QuizPA")
                    {
                        cf.client.Delete("Quizes/QuizesPA/" + q.nombreQuiz);
                        cf.client.Delete("Preguntas/PreguntasMultiOpcion/" + q.nombreQuiz);
                    }
                       
                        
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Quiz q = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    if (q.estado is Borrador)
                    {
                        q.cambiarEstado(new Publicado());
                        MessageBox.Show("Quiz publicado con éxito");
                        

                    }
                    else MessageBox.Show("El quiz " + q.nombreQuiz + "con estado : " + q.estado.GetType().Name +
                        ", no se puede publicar ya que no está en estado Borrador");
                }
            }
            mostrarQuizes();
            deseleccionarChecks();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Quiz q = null;
            Quiz aux = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    if (q.estado is Publicado)
                    {
                        q.cambiarEstado(new Borrador());
                        MessageBox.Show("Quiz cancelado con éxito");
                        aux = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                        dataGridQuizes.Rows[i].Cells[7].Value = aux.estado.GetType().Name;
                    }
                    else MessageBox.Show("El quiz " + q.nombreQuiz + " no se puede cancelar ya que no se ha publicado todavia");

                }
            }
            deseleccionarChecks();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Quiz q = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    if (!(q.estado is Borrador)) MessageBox.Show("El quiz ya ha sido publicado, no puedes editar preguntas");
                    else
                    {
                        EditarPreguntasMO edit = new EditarPreguntasMO(q);
                        edit.ShowDialog();
                    }
                }
            }
            deseleccionarChecks();
        }

        private void button10_Click(object sender, EventArgs e)
        {
             Quiz q = null;
             List<Quiz> listaQuizes = new List<Quiz>();
             for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
                {
                    bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                    if (isCellChecked == true)
                    {
                        q = services.getQuizById((string)dataGridQuizes.Rows[i].Cells[1].Value);
                            listaQuizes.Add(q);
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
            Quiz q = null;
            Quiz aux = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    //if (!(q.estado is Terminado)) MessageBox.Show("El quiz debe estar en estado Terminado para publicar los resultados");
                    //else
                    //{
                        q.cambiarEstado(new ResultadosPublicados());
                        q.notificar();
                        MessageBox.Show("Resultados publicados con éxito");
                        aux = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                        dataGridQuizes.Rows[i].Cells[7].Value = aux.estado;
                    //}
                    

                }
            }
            deseleccionarChecks();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Quiz q = null;
            Quiz aux = null;
            for (int i = 0; i < dataGridQuizes.Rows.Count - 1; i++)
            {
                bool isCellChecked = (bool)dataGridQuizes.Rows[i].Cells[0].Value;
                if (isCellChecked == true)
                {
                    q = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                    //if (!(q.estado is Publicado)) MessageBox.Show("El quiz debe estar en estado Publicado para poder finalizarlo");
                    //else
                    //{
                        q.cambiarEstado(new Terminado());
                        MessageBox.Show("Terminado con éxito");
                        aux = services.getQuizById(dataGridQuizes.Rows[i].Cells[1].Value.ToString());
                        dataGridQuizes.Rows[i].Cells[7].Value = aux.estado;
                    //}


                }
            }
            deseleccionarChecks();
        }
    }
}
