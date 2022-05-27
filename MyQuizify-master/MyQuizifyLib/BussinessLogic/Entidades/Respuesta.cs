namespace MyQuizifyLib.BussinessLogic.Entidades
{
    public abstract class Respuesta
    {
        public string enunciado;
        public bool correcta;
        public Respuesta(string enunciado)
        {
            this.enunciado = enunciado;

        }
        public abstract void inicialize(bool correcta);
        public override string ToString()
        {
            return enunciado;
        }
    }
}
