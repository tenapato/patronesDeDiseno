// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    interface IFabrica
    {
        void crearProducto();
        IComponenteElectronico  ObtenerComponenteElectronico { get; }

    }
}

