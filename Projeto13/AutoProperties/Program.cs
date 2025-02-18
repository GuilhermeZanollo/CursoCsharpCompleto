using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            //p.Quantidade = -10; // SEM O ENCAPSULAMENTO É ISSO QUE O USUÁRIO PODE FAZER, adicionar um valor para quantidade de produtos 
            // Para isso não ocorrer, devo transformar o atributo QUANTIDADE no tipo PRIVATE

            p.Nome = "T"; // chamando método set e alterando o nome da TV
            //p.Preco = 400.00;

            Console.WriteLine(p.Nome); // busco o nome com método Get para o atributo nome
            Console.WriteLine(p.Preco); // Com esses métodos conseguimos controlar como nossa classe deve ser utilizada
            Console.WriteLine(p.Quantidade);
        }
    }
}
