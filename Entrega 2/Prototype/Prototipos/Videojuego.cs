namespace Patron.Prototype
{
    class CVideojuego : IPrototipo
    {
        private string nombre;
        private int costo;

        public string Nombre { get => nombre; set => nombre = value; }

        public CVideojuego(string pNombre, int pCosto)
        {
            nombre = pNombre;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, costo);
        }
        public object Clonar()
        {
            CVideojuego clon = new CVideojuego(nombre, costo);

            return clon;
        }

    }
}