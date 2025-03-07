using System.Globalization;
using Projeto44.Entities;
using Projeto44.Services;

namespace Projeto44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Projeto com interface
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

            Rent rent = new Rent(pickUp, returnTime, new Vehicle(carModel));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService()); // Recebe BrazilTaxService pois torna menos 
                   
            rentalService.ProcessInvoice(rent); // Recebe como argumento dados de Rent e envia para o método ProcessInvoice da classe RentalService

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rent.Invoice); // Busca o valor do atributo Invoice na classe Rent (ToString)
        }
    }
}