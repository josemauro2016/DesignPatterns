using System;

namespace Adapter
{
    public class MercadoPago : IMercadoPago
    {
        private Token token;
        public void EnviarPagamento()
        {
            token = TokenDeAutorizacao();
            Console.WriteLine("Enviando pagamentos com Mercado Pago.");
        }

        public void ReceberPagamento()
        {
            token = TokenDeAutorizacao();
            Console.WriteLine("Recebendo pagamentos com Mercado Pago.");
        }

        public Token TokenDeAutorizacao()
        {
            return new Token();
        }
    }
}
