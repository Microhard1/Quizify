using MyQuizifyGUI.Forms.ContestacionQuizes;
using MyQuizifyLib.BussinessLogic.Entidades;
using System;
using System.Windows.Forms;

namespace MyQuizifyGUI.Forms
{
    public partial class CaracteristicasPrincipales : Form
    {
        private Quiz quiz;
        private Aplicacion app;
        public CaracteristicasPrincipales(Quiz quiz, Aplicacion app)
        {
            InitializeComponent();
            this.app = app;
            lblNombreQuiz.Text = quiz.nombreQuiz;
            lblDuracion.Text = quiz.duracion + " minutos";
            lblDificultad.Text = quiz.dificultad;
            lblCurso.Text = quiz.asignatura.nombre;
            lblPeso.Text = quiz.peso + "%";
            lblFechaInicio.Text = quiz.fechaDeInicio.ToString();
            lblFechaFin.Text = quiz.fechaFin.ToString();
            this.quiz = quiz;
        }


        private void btbAceptar_Click(object sender, EventArgs e)
        {
            if (quiz.GetType().Name == "QuizMO")
            {
                ContestacionDeQuizesMultiOpcion contestacionDeQuizesMultiOpcion = new ContestacionDeQuizesMultiOpcion(quiz, app);
                contestacionDeQuizesMultiOpcion.ShowDialog();
                Close();
            }
            else if (quiz.GetType().Name == "QuizVF")
            {
                ContestacionQuizVF contQuizVF = new ContestacionQuizVF(quiz, app);
                contQuizVF.ShowDialog();
                Close();
            }
            else if (quiz.GetType().Name == "QuizPA")
            {
                ContestacionQuizRA contQuizRA = new ContestacionQuizRA(quiz, app);
                contQuizRA.ShowDialog();
                Close();
            }

        }
    }
}
