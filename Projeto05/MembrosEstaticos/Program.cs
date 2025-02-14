using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static double Pi = 3.14;//DEFINIÇÃO DO VALOR DE PI // tem que ser estático/static
        static void Main(string[] args)
        {
            /* Problema exemplo de membros estáticos
             Fazer um programa para ler um valor númerico qualquer, e dai mostrar quanto seria o valor de uma circunferencia
            e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
            */

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio); // Calcula a circunferência chamando o método Circunferencia com o valor do raio.
            double volume = Volume(raio); // Calcula o volume chamando o método Volume com o valor do raio.

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r) // Tem que retornar o valor do RAIO passado pelo usuário com esse parametro. 
        {                                       // Nao precisa adicionar o public nessas funções/metodos pois eles já estao dentro da classe.
            return 2.0 * Pi * r;                // Para chamar esses metodos que sao da PROPRIA classe MAIN, é preciso tornar os metodos estaticos
                                                // ou seja, temos que transformar a circunferencia e o volume estaticos, para chama-los na classe
                                                //main.
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}