using System;

namespace Bridge.Platform
{
    internal class TwichTV : IPlatform
    {
        public TwichTV()
        {
            ConfiguraRMTP();
            Console.WriteLine("TwichTV: Transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("TwichTV: Autorizando aplicação");
        }

        public void ConfiguraRMTP()
        {
            AuthToken();
            Console.WriteLine("TwichTV: Configurando servidor RMTP");
        }
    }
}
