using System.Globalization;
using System.Runtime.CompilerServices;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) // ESTOU DIZENDO AQUI QUE NA HORA QUE INSTANCIAR UM CONSTRUTOR
        {                                                         // SOU OBRIGADO A INFORMAR O NOME, O PRECO E QUANTIDADE NO CONSTRUTOR
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) // SOBRECARGA AQUI ESTOU DIZENDO QUE VAI RECEBER APENAS O NOME E O PRECO mas vou 
        {                                         // inicializar a quantidade com 5 unidades
            Nome = nome;
            Preco = preco;
            Quantidade = 5; // Inicializando 0
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}