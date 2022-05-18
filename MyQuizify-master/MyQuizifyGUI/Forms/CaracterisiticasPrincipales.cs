using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyQuizifyGUI.Forms.ContestacionQuizes;
using MyQuizifyLib.BussinessLogic.Entidades;

namespace MyQuizifyGUI.Forms
{
    public partial class CaracteristicasPrincipales : Form
    {
        private Quiz quiz;
        public CaracteristicasPrincipales(Quiz quiz)
        {
            InitializeComponent();
            lblNombreQuiz.Text = quiz.nombreQuiz;
            lblDuracion.Text = quiz.duracion + " minutos";
            lblDificultad.Text = quiz.dificultad;
            lblCurso.Text = quiz.asignatura.nombre;
            lblPeso.Text = quiz.peso + "";
            lblFechaInicio.Text = quiz.fechaDeInicio + "";
            lblFechaFin.Text = quiz.fechaFin + "";
            this.quiz = quiz;
        }

        private void panelQuizes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
            if (quiz.GetType().Name=="QuizMO")
            {
                ContestacionDeQuizesMultiOpcion contestacionDeQuizesMultiOpcion = new ContestacionDeQuizesMultiOpcion(quiz);
                contestacionDeQuizesMultiOpcion.ShowDialog();
                this.Close();
            }
            else if (quiz.GetType().Name == "QuizVF")
            {
                ContestacionQuizVF contQuizVF = new ContestacionQuizVF(quiz) ;
                contQuizVF.ShowDialog();
                this.Close();
            }
            else if (quiz.GetType().Name == "QuizPA")
            {
                ContestacionQuizRA contQuizRA = new ContestacionQuizRA(quiz);
                contQuizRA.ShowDialog();
                this.Close();
            }
            
        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {

        }
    }
}
