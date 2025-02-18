using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto14
{
    internal class Conta
    {
        public string Name { get; set; }
        public int NumeroConta { get; private set; } // NÚMERO DA CONTA NAO VAI SER ALTERADO, ENTÃO CONSIDERA-SE COMO (PRIVATE SET)
        public double Saldo { get; private set; } // SALDO DA CONTA NAO VAI SER ALTERADO, ENTÃO CONSIDERA-SE COMO (PRIVATE SET)

        public Conta(string name, int numeroConta)
        {
            Name = name;
            NumeroConta = numeroConta;
            Saldo = 0.0;
        }

        public Conta(string name, int numeroConta, double saldo)
        {
            Name = name;
            NumeroConta = numeroConta;
            Saldo = saldo;
        } 

        // métodos: 
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return "Conta " 
                + NumeroConta
                + ", Titular: "
                + Name 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


