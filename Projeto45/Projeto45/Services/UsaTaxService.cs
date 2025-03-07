using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto45.Services
{
    internal class UsaTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.3; // 30%
            }
            else
            {
                return amount * 0.2; // 20%
            }
        }
    }
}
