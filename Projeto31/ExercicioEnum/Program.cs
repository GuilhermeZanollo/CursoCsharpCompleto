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
             um mês e mostrar qual foi o salário do funcionário nesse mês.*/

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine() ?? string.Empty); // Transformando level em ENUM
            Console.Write("Base salary: ");
            double BaseSalary = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            int contractsNumber = int.Parse(Console.ReadLine() ?? string.Empty);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, BaseSalary, dept); // Recebe dept da variavel instanciada acima

            Console.WriteLine();

            for (int i = 1; i <= contractsNumber; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine() ?? string.Empty);
                HourContract contract = new HourContract(date, valuePerHour, hours); // Instanciando o contrato
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine() ?? string.Empty;
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}
