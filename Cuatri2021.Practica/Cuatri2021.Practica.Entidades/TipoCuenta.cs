namespace Cuatri2021.Practica.Entidades
{
    public class TipoCuenta
    {
        private int _id;
        private string _tipo;

        public TipoCuenta(int id, string tipo)
        {
            _id = id;
            _tipo = tipo;
        }

        public int Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}