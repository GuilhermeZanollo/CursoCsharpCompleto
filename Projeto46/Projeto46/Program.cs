using System.Globalization;
using Projeto46.Entities;
using Projeto46.Services;

namespace Projeto43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Uma empresa deseja automatizar o processamento de seus contratos. O processamento de um contrato consiste em gerar as parcelas
            a serem pagas para aquele contrato, com base no número de meses desejado.

            A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas. Os serviços de pagamento online tipi
            camente cobram um juro mensal, bem como uma taxa por pagamento. Por enquanto, o serviço contratado pela empresa é o do Paypal,
            que aplica juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%.

            Fazer um programa para ler os dados de um contrato (número do contrato, data do contrato, e o valor total do controle). Em se
            guida, o programa deve ler o número de meses para parcelamento do contrato, e dai gerar os registros de parcelas a serem pagas
            (data e valor), sendo a primeira parcela a ser paga um mês após a data do contrato, a segunda parcela dois meses após o contra
            to e assim por diante. Mostrar os dados das parcelas na tela.
            */

            Console.WriteLine("Enter Contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());

            Projeto46.Entities.Contract contract = new Projeto46.Entities.Contract(contractNumber, contractDate, contractValue); //A classe Contract recebe o número do contrato, a data e o valor total do contrato, armazenando-os em suas propriedades.
            ContractService contractService = new ContractService(new PaypalService()); // A classe ContractService recebe uma instância de PaypalService como parâmetro, o que permite que o PayPal seja utilizado para calcular juros e taxas.
            contractService.ProcessContract(contract, installmentsNumber); // O método ProcessContract da classe ContractService é chamado para calcular as parcelas, com base no número de meses informado.O processamento ocorre conforme o seguinte fluxo:

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments) // Para cada parcela na propriedade Installments (lista)
            {
                Console.WriteLine(installment); // Realize a saída de installment
            }
        }
    }
}