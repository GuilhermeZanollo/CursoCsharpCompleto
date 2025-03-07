using System.Globalization;
using Projeto45.Entities;
using Projeto45.Services;
using Projeto45.Services;

namespace Projeto43
{
    class Program
    {
        static void Main(string[] args)
        {
            //Projeto com interface (MODELO ACRESCENTANDO 2 MÉTODOS UsaTaxService e BrazilTaxService)
            /* Uma locadora brasileira de carros cobra um valor por hora para locações de até 12horas. Porém
             se a duração da lcoação ultrapassar 12 horas, a locação será cobrada com base em um valor diário.
            Além do valor da locação, é acrescido no preço o valor do imposto conforme regras do país que, no
            caso do Brasil, é 20% para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um programa
            que lê os dados da locação (modelo do carro, instante inicial e final da locação), bem como o valor 
            por hora e valor diário de locação. O programa deve então gerar a nota de pagamento (contendo valor da 
            locação, valor do imposto e valor total do pagamento) e informar os dados na tela. Veja os exemplos.
            */

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine() ?? string.Empty;
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickUp = DateTime.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime returnTime = DateTime.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);

            Console.Write("Enter country for tax calculation (Brazil/USA): ");
            string country = Console.ReadLine()?.Trim().ToLower();

            ITaxService taxService = country == "usa" ? new UsaTaxService() : new BrazilTaxService(); // verifica se a variavel country é USA, se for verdadeiro a instancia de UsaTaxService acontece

            Rent rent = new Rent(pickUp, returnTime, new Vehicle(carModel));
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, taxService);
            rentalService.ProcessInvoice(rent); // Recebe como argumento dados de Rent e envia para o método ProcessInvoice da classe RentalService

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rent.Invoice); // Busca o valor do atributo Invoice na classe Rent (ToString)
        }
    }
}