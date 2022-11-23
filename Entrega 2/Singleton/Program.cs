// un solo logger para una actividad
//evitamos crear los New Singleton
namespace Patrones
{
    class MainApp
    {
        static void Main()
        {
            Singleton? s1 = Singleton.Instance();
            Singleton? s2 = Singleton.Instance();


            if (s1 == s2)
            {
                Console.WriteLine("Son iguales");
            }

            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();

            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();


            // Load balance 15 server requests

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 5; i++)
            {
                string server = balancer.Server;

                Console.WriteLine("Pasar solicitud a : " + server);
            }

            //Console.ReadKey();
        }
    }
}