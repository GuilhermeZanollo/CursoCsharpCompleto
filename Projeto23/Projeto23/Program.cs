using System.Numerics;
using Projeto23;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("How many employees will be registered? ");
            int hiringNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine("Employee #1: ");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name:");
            string employeeName = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Employee #2: ");
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            employeeName = Console.ReadLine();
            Console.Write("Salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Employee #3: ");
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            employeeName = Console.ReadLine();
            Console.Write("Salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase : ");
            int salaryIncrease = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());

        }
    }
}