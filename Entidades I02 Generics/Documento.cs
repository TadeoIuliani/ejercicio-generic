namespace Entidades_I02_Generics
{
    public class Documento
    {
        private int _numero;

        public Documento(int numero)
        {
            _numero = numero;
        }

        public int Numero { get => _numero; set => _numero = value; }
    }
}
