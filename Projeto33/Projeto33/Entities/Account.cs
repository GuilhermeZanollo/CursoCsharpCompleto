using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto33.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder {  get; private set; } // Private não permite que você altere em outra classe a não ser ESSA.
        public double Balance { get; protected set; } // (Protected) Permite que você altere uma subclasse, no caso a "BusinessAccount" apenas.

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
