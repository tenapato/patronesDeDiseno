using MetodoFabrica02.Fabrica;
using MetodoFabrica02.Fabrica.Creadores;

namespace MetodoFabrica02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IDispositivoElectronico dispositivo_electronico;
            Console.WriteLine("Cuanto dinero tienes para tu dispositvo Electronico?");
            //dato = Console.ReadLine();
            dato = "10000";
            dinero = Convert.ToInt32(dato);
            // Obtenemos el vehiculo de la fabrica
            dispositivo_electronico = CCreador.MetodoFabrica(dinero);
            dispositivo_electronico.Encender();
            dispositivo_electronico.CorrerPrograma();
            dispositivo_electronico.TomarFoto();
        }
    }
}