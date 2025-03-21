namespace Projeto46.Interfaces
{
    internal interface IOnlinePaymentService // Definição do contrato
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
