namespace MetodoFabrica02.Fabrica
{
    internal class CAComputadora : IDispositivoElectronico
    {
        public void Encender()
        {
            Console.WriteLine("Se encendio la computadora");
        }
        public void TomarFoto()
        {
            Console.WriteLine("Se tomo una foto!");
        }
        public void CorrerPrograma()
        {
            Console.WriteLine("Se corrio Word!");
        }
    }
}