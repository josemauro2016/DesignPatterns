using System;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();
            //Payoneer payment = new Payoneer();

            //IPayPalPayment payment = new PayoneerAdapter(new Payoneer());
            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            
            Console.ReadLine();
        }
    }
}
