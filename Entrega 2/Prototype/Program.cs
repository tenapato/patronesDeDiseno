
namespace Patron.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocamos el admin
            CAdminPrototipos admin = new CAdminPrototipos();

            //Creamos una instancia
            CVideojuego game = new CVideojuego("Smash Bros.", 1599);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Juego", game);

            //Obtenemos un objeto del prototipo anterior
            CVideojuego game2 = (CVideojuego)admin.ObtenPrototipo("Juego");

            //Cambiamos el estado
            game2.Nombre = "Guilty Gear";

            Console.WriteLine(game);
            Console.WriteLine(game2);
            Console.WriteLine("-----");

            //Obtenemos una instancia del COSTOSO
            CValores val = (CValores)admin.ObtenPrototipo("Valores");
            Console.WriteLine(val);
        }

    }
}