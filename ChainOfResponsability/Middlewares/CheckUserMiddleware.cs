using System;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability.Middlewares
{
    public class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }
        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválido");
                return false;
            }

            if (!server.IsValidPassword(email, password))
            {
                Console.WriteLine("Email e ou senha inválidos");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
