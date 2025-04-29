namespace Adapter
{
    public interface IPayoneerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
