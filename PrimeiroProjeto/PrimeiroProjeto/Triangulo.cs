using System;

namespace PrimeiroProjeto
{
    internal class Triangulo
    {
        
        public double A; // atributos que estão na classe triângulo, são públicos para serem acessados pelo nosso programa principal "Program.cs"
        public double B;
        public double C;
        
        public double Area() // CRIAMOS METODO DA CLASSE TRIANGULO PARA RETORNA-LO A CLASSE PROGRAM / É UMA FUNÇÃO DENTRO DA PROPRIA CLASSE
        {                    // Na função área, nao é necessário adicionar parametros pois apenas A, B e C já são suficiente para o metodo
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}