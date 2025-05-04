using System;
using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability
{
    public class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@josemauro.com", "1234567");
            server.RegisterUser("user@josemauro.com", "123456");

            Middleware middleware = new CheckUserMiddleware(server);
            var checkPermissionMiddleware = new CheckPermissionMiddleware();
            var checkWeakPassword = new CheckWeakPassword();
            middleware.LinkWith(checkPermissionMiddleware);

            checkPermissionMiddleware.LinkWith(checkWeakPassword);
            server.SetMiddleware(middleware);
        }
        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a sua senha:");
                string password = Console.ReadLine();
                done = server.Login(email, password);
            }
            while (!done);

            Console.ReadLine();
        }
    }
}
