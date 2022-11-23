namespace Patrones.AbstractFactory
{
    class FabricaElectronica : IFabrica
    {
        private IComponentePantalla pantalla_digial;
        
        public IComponentePantalla ObtenerComponente
        {
            get { return panatalla_digial; }
        }


        public void crearProducto()
        {
            Console.WriteLine("Estamos produciendo buscando tu panatalla");
            pantalla_digital = new PantallaDigital();
        }
    }
}