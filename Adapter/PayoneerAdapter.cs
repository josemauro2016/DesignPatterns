namespace Adapter
{
    public class PayoneerAdapter : IPayPalPayment
    {
        private Payoneer payoneer;

        public PayoneerAdapter(Payoneer payoneer)
        {
            this.payoneer = payoneer;
        }

        public Token AuthToken()
        {
            return this.payoneer.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payoneer.SendPayment();
        }

        public void PayPalReceive()
        {
            this.payoneer.ReceivePayment();
        }
    }
}
