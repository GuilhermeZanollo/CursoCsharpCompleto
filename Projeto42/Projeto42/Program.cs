using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Projeto42.Entities;
using Projeto42.Entities.Exceptions;

namespace Projeto42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Holder: ");
                string holder = Console.ReadLine() ?? string.Empty;
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture)); // Pega o saldo do objeto que foi gravado
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Withdraw error: " + ex.Message);
            }
        }
    }
}