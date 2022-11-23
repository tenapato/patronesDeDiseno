namespace MetodoFabrica02.Fabrica.Creadores
{
    internal class CCreador
    {

        internal static IDispositivoElectronico MetodoFabrica(int dinero)
        {
            IDispositivoElectronico temp = null;

            if (dinero > 1000)
            {
                temp = new CAComputadora();
            }
            return temp;
        }
    }
}