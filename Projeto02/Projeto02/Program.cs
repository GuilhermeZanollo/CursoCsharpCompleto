using System;
using System.Globalization;
using Projeto02;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); // instanciação do objeto

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = (Console.ReadLine());
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do produto: " + p.Nome + "," + p.Preco + "," + p.Quantidade + ", Total: $" + valorTotal); (AO INVÉS DISSO, UTILIZAMOS O DE BAIXO)
            Console.WriteLine("Dados do produto: " + p);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // QUANTOS PRODUTOS VOU ADICIONAR? O QTE QUE FOI ME PASSADO ANTERIORMENTE PELO USUÁRIO.
            Console.WriteLine("Dados atualizados: " + p);
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}