using System;
using Projeto33.Entities;

namespace Projeto33
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // UPCASTING
            Account acc1 = bacc; // possivel pois businessacount é um account e savingsAccount é um account também
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            //BusinessAccount acc4 = acc2; -> assim nao funciona, precisa fazer o casting, como abaixo:
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
        }
    }
}