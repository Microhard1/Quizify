namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class RespuestaMO : Respuesta
    {
        public bool correcta;
        public RespuestaMO(string enunciado) : base(enunciado)
        {
            correcta = false;
        }
        public override void inicialize(bool correcta)
        {
            this.correcta = correcta;
        }
    }
}
