namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public class RespuestaVF : Respuesta
    {
        public bool correcta;
        public RespuestaVF(string enunciado) : base(enunciado)
        {

        }
        public override void inicialize(bool correcta)
        {
            this.correcta = correcta;
        }
    }
}
