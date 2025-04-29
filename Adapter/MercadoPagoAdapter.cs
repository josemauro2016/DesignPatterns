namespace Adapter
{
    internal class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return this.mercadoPago.TokenDeAutorizacao();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.EnviarPagamento();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.ReceberPagamento();
        }
    }
}
