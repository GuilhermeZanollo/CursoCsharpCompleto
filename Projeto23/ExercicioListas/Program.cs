using System.Numerics;
using System.Globalization;
using Projeto23;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int hiringNumbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hiringNumbers; i++)
            {
                Console.WriteLine($"\nEmployee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee { Id = id, Name = name, Salary = salary });
            }

            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(e => e.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.SalaryIncrease(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}

