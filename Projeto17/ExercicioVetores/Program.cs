using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using Projeto17;



namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            */

            Console.Write("How many rooms will be rented? ");
            int N = int.Parse(Console.ReadLine()); // LE O NUMERO DE QUARTOS QUE VAO SER ALUGADOS
            int qrooms = 10; // INICIALIZA COM NUMERO TOTAL DE QUARTOS DISPONIVEIS
         
            Estudante[] vector = new Estudante[qrooms]; // inicializa um vetor com capacidade de quartos que é 10

            for (int i = 0; i<N; i++)
            {
                Console.WriteLine("Rent #"+(i + 1)+": ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vector [room] = new Estudante { Name = name, Email = email, Room = room }; // Atribui o estudante ao quarto correto
            }

            Console.WriteLine();

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < qrooms; i++)
            {
                if (vector[i] != null)
                {
                    Console.Write(vector[i].Room + ": ");
                    Console.Write(vector[i].Name + ", ");
                    Console.WriteLine(vector[i].Email);
                }
            }

            Console.ReadLine();
        }
    }
}