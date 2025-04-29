using System;

namespace Adapter
{
    public class Payoneer : IPayoneerPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com Payoneer.");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Payoneer.");
        }
    }
}
