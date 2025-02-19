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
            Calculator.Triple(ref a); // adicionando o ref // SEM O "ref" É POSSIVEL REALIZAR ESSA MULTIPLICAÇÃO
            Console.WriteLine(a);     // POIS O RESULTADO FICA DENTRO DE X NA CLASSE CALCULATOR E o "a" NÃO ALTERA NADA.
        }
    }
}