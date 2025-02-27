using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto35.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } // Private não permite que você altere em outra classe a não ser ESSA.
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

        public virtual void Withdraw(double amount) // o metodo withdraw pode ser sobreescrito agora nas subclasses por conta do VIRTUAL
        {
            Balance -= amount + 5.0; // VAI SACAR A QUANTIA MAIS OS 5
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}