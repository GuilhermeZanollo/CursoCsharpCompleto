using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using Projeto19;



namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a); // adicionando o ref
            Console.WriteLine(a);
        }
    }
}