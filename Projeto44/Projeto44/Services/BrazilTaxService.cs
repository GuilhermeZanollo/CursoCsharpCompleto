﻿using Projeto44.Interfaces;

namespace Projeto44.Services
{
    internal class BrazilTaxService : ITaxService // Implementando a interface
    {
        public double Tax(double amount) // Amount é o basicPayment
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
