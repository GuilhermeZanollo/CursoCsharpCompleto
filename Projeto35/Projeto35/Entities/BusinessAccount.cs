using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto35.Entities;

namespace Projeto34.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) // extensao dos proximos 
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) // Loan - empréstimo
        {
            if (amount <= LoanLimit)
            {
                Balance += LoanLimit;
            }
        }
    }
}
