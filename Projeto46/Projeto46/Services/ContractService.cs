using Projeto46.Entities;
using Projeto46.Interfaces;

namespace Projeto46.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months; // O valor total do contrato (contract.TotalValue) é dividido pelo número de meses para obter a parcela básica.
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i); // AddMonths adiciona um mês no contrato
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i); //  É realizado o cálculo do valor total da parcela, que inclui juros e taxas de pagamento.
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota); // Calcular o valor total da parcela, que inclui juros e taxas de pagamento.
                contract.AddInstallment(new Installment(date, fullQuota)); // É instanciando o objeto Installment e já passado 
            }
        }
    }
}
