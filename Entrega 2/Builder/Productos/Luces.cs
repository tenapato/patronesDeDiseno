namespace Builder03
{
    interface ILuces
    {
        string informacion();
    }

    class luces : ILuces 
    {
        public string informacion()
        {
            return "500 Nits de potencia";
        }
    }

    class lucesSuper : ILuces
    {
        public string informacion()
        {
            return "1000 Nits de potencia";
        }
    }

}