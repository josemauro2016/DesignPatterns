namespace Adapter
{
    public interface IMercadoPago
    {
        Token TokenDeAutorizacao();
        void EnviarPagamento();
        void ReceberPagamento();
    }
}
