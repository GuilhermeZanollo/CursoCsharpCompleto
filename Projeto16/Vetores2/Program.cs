using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using Projeto16;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produto. Armazene os N produtos em um vetor.
             Em seguida, mostrar o preço médio dos produtos.
             Entradas:  3
                        TV
                        900.00
                        Fryer
                        400.00
                        Stove
                        800.00
            */
            int N = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[N]; // vect recebe um new produto // até aqui criei apenas as caixinhas 0, 1, 3 (se n for 3) 

            for (int i = 0; i<N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price }; // INSTANCIANDO AS CAIXINHAS CRIADAS ANTERIORMENTE
            }

            double sum = 0.0;
            for (int i = 0; i<N; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / N;

            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}