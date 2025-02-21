using System;
using System.Transactions;
using System.Globalization;
using Microsoft.VisualBasic;
using Projeto31.Entities;
using Projeto31.Entities.Enums;

namespace Projeto31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar do usuário
             um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo (próxima página).*/

            Worker worker = new Worker();

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            worker.Name = Console.ReadLine() ?? string.Empty;
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            worker.BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            int contractsNumber = int.Parse(Console.ReadLine() ?? string.Empty);

            Department department = new Department(deptName);
            Worker worker2 = new Worker(string.Empty, Enum.Parse<WorkerLevel>(Console.ReadLine()), double.Parse(Console.ReadLine()), department);

            Console.WriteLine();

            for (int  i = 1; i <= contractsNumber; i++)
            {
                Console.WriteLine("Enter #" +i+ " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string date = Console.ReadLine();
            
            Console.WriteLine();
        }
    }
}
