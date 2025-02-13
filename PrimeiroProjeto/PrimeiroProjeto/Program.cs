using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Problema exemplo - Sem a utilização de orientação a objetos
            //Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). Em seguida, mostrar
            //o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
            //A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a seguinte (fórmula de Heron):

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            double Ax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Bx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Cx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            double Ay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double By = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Cy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double sx = (Ax + Bx + Cx) / 2;
            double areaX = Math.Sqrt(sx * (sx - Ax) * (sx - Bx) * (sx - Cx));

            double sy = (Ay + By + Cy) / 2;
            double areaY = Math.Sqrt(sy * (sy - Ay) * (sy - By) * (sy - Cy));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área é do triângulo: X, com valor de:" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            } else
            {
                Console.WriteLine("A maior área é do triângulo: Y, com valor de:" + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
            */

            
            //Para melhorar o exemplo anterior, vamos usar a classe triangulo, da forma abaixo: 

            Triangulo x, y; // 2 variáveis do tipo triângulo -> Porem não basta reclarar variaveis que sao de tipo de classe, é necessário instanciar

            x= new Triangulo(); //objeto x (instanciando objetos)
            y= new Triangulo(); //objeto y (instanciando objetos)

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area(); // aqui eu recebo o retorno do metodo
            double areaY = y.Area(); // aqui eu recebo o retorno do metodo 

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área é do triângulo: X, com valor de:" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("A maior área é do triângulo: Y, com valor de:" + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
            

            /*
            // Primeiro Exercício testando CLASSE, OBJETO E ATRIBUTOS
            // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
           
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da primeira pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da segunda pessoa: ");
            p2.Idade= int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: " + p1.Nome);
            Console.WriteLine("Idade: " + p1.Idade);
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: " + p2.Nome);
            Console.WriteLine("Idade: " + p2.Idade);

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
            */

            /* 
            // Exercicio 2
            
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            double salarioMedio;

            
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: " + f1.Nome);
            Console.WriteLine("Salário: " + f1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: " + f2.Nome);
            Console.WriteLine("Salário: " + f2.Salario.ToString("F2", CultureInfo.InvariantCulture));

            salarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
            */

            /* 
            //Forma mais correta de se fazer exercicio 2:
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}