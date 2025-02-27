using System;
using System.Globalization;

namespace Projeto38
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e) // e é um apelido que dei para exceção // sempre importante colocar o tipo de exceção mais especifico possivel.
            {
                Console.WriteLine("Erro! " + e.Message); // Ao invés de quebrar a execução, agora o programa está exibindo a mensagem que eu defini.
            }
            */

            // outra forma para exception: 

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Division by zero is not allowed"); 
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error " + e.Message);
            }

        }
    }
}