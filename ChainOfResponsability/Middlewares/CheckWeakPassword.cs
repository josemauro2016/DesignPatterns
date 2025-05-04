using System;

namespace ChainOfResponsability.Middlewares
{
    public class CheckWeakPassword : Middleware
    {
        
        public override bool Check(string email, string password)
        {
            
            if (password.Equals("123456"))
            {
                Console.WriteLine("Esta senha é muito fraca recomendamos a troca");
            }
            
            return CheckNext(email, password);
        }
    }
}
