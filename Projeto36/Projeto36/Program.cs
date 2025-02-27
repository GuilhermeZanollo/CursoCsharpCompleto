using System.Globalization;
using Projeto36.NewFolder;

namespace Projeto36
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employeeNumbers = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine();

            for (int i = 1; i <= employeeNumbers; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");
                char response = char.Parse(Console.ReadLine() ?? string.Empty);

                if (response == 'n')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine() ?? string.Empty;
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine() ?? string.Empty;
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYEMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
