using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using Projeto20;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple); // o "a" é a "origin" na classe CALCULATOR e o triple é o result (out)
            Console.WriteLine(triple);
        }
    }
}