using System;

namespace Bridge.Platform
{
    public class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfiguraRMTP();
            Console.WriteLine("Youtube: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação");        
        }

        public void ConfiguraRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP");
        }
    }
}
