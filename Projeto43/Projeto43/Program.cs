using System.Globalization;
using Projeto43.Entities;
using Projeto43.Services;

namespace Projeto43
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESSE É UM EXEMPLO RUIM DE PROJETO, SEM UTILIZAR INTERFACES, PROJETO 44 CORRIGIDO UTILIZANDO INTERFACE
            /* Uma locadora brasileira de carros cobra um valor por hora para locações de até 12horas. Porém
             se a duração da lcoação ultrapassar 12 horas, a locação será cobrada com base em um valor diário.
            Além do valor da locação, é acrescido no preço o valor do imposto conforme regras do país que, no
            caso do Brasil, é 20% para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um programa
            que lê os dados da locação (modelo do carro, instante inicial e final da locação), bemm como o valor 
            por hora e valor diário de locação. O programa deve então gerar a nota de pagamento (contendo valor da 
            locação, valor do imposto e valor total do pagamento) e informar os dados na tela. Veja os exemplos.
            */

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickUp = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime returnTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Rent rent = new Rent(pickUp, returnTime, new Vehicle(carModel));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

            rentalService.ProcessInvoice(rent);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rent.Invoice);
        }
    }
}