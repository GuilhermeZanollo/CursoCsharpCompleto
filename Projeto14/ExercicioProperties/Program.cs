using System;
using System.Globalization;
using Projeto14;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(name, numeroConta, depositoInicial); // nao da para colocar "Conta c = new Conta aqui pois da problema de escopo
            }
            else
            {
                c = new Conta(name, numeroConta);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(quantia); // vou chamar no meu objeto C o metodo DEPOSITO e passar como argumento a quantia
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // PARA EU REUTILIZAR A VARIAVEL "QUANTIA" NÃO POSSO COLOCAR O TIPO DOUBLE NOVAMENTE.
            c.Saque(quantia); 
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
        }
    }
}
