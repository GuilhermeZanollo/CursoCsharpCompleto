using System;
using System.Data;
using System.Drawing;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida,
            mostrar a altura média dessas pessoas.
            Entradas:   3
                        1.72
                        1.56
                        1.80
            */

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; // => Cria o vetor na memória

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // VET [I] INICIA NA POSIÇÃO 0
            }

            // ENCONTRANDO A MEDIA
            double sum = 0.0;
            for (int i = 0; i<n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}