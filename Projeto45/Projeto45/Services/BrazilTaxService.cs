using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto45.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount) // O método precisa ser definido para implementar ITaxService
        {
            if (amount <= 100.0)
            {
                return amount * 0.2; // 20%
            }
            else
            {
                return amount * 0.15; // 15%
            }
        }
    }
}
