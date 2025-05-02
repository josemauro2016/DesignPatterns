using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platform
{
    public class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfiguraRMTP();
            Console.WriteLine("Facebook: Transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação");
        }

        public void ConfiguraRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP");
        }
    }
}
