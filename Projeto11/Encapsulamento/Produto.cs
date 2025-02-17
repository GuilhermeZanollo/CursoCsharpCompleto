using System.Globalization;
using System.Runtime.CompilerServices;
namespace Course
{
    class Produto
    {
        private string _nome; //quando for trabalhar com atributo privativo, o formato do nome fica com _ e letra minuscula
        private double _preco; // depois de deixar privativo, é necessário chamar os atributos com método get e set
        private int _quantidade;

        public Produto() 
        {
        }
        public Produto(string nome, double preco, int quantidade) // FORMAS DE USAR O CONSTRUTOR
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome() // Crio esse método para buscar/consultar nome 
        {
            return _nome;
        }

        public void SetNome(string nome) // void pois nao vai adicionar nada como saída, apenas vai alterar o nome
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome; // posso adicionar condicional também
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}