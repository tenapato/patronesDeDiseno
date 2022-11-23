// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fabrica 1
            IFabrica mifabrica = new FabricaElectronica();
            mifabrica.crearProducto();

            IComponentePantalla _pantalla_ = mifabrica.ObtenerComponenteElectronico;
            

        
        }
    }
}

