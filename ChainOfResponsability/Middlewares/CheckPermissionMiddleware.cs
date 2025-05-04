using System;

namespace ChainOfResponsability.Middlewares
{
    public class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@josemauro.com"))
            {
                Console.WriteLine("Seja bem-vindo administrador.");
                //return true;
            }

            Console.WriteLine("Seja bem-vindo.");

            return CheckNext(email, password);
        }
    }
}
