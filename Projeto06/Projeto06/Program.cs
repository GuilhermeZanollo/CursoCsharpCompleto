using System;
using System.Globalization;
using Projeto06;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Problema exemplo de membros estáticos
             Fazer um programa para ler um valor númerico qualquer, e dai mostrar quanto seria o valor de uma circunferencia
            e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
            */
           
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio); // Calcula a circunferência chamando o método Circunferencia com o valor do raio.Só que dessa vez chamando a classe que a Circunferencia está (classe calculadora)
            double volume = Calculadora.Volume(raio); // Calcula o volume chamando o método Volume com o valor do raio. Só que dessa vez chamando a classe que o Volume está (classe calculadora)

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)); // chama a classe calculadorado
        }
    }
}