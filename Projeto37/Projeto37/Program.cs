using System.Globalization;
using Projeto37.Entities;

namespace Projeto37
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Name: ");
                String name = Console.ReadLine() ?? string.Empty;
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine() ?? string.Empty);
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
