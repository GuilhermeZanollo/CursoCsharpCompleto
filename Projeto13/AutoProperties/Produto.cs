using System.Globalization;
using System.Runtime.CompilerServices;
namespace Course
{
    class Produto
    {
        private string _nome; //quando for trabalhar com atributo privativo, o formato do nome fica com _ e letra minuscula
        public double Preco { get; private set; } // utilizando o auto properties
        public int Quantidade { get; private set; } // utilizando o auto properties // utilizando o PROP + TAB é só alterar

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade) // FORMAS DE USAR O CONSTRUTOR 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome // AQUI É A IMPLEMENTAÇÃO DE UMA PROPERTY, DEFININDO AS OPERAÇÕES DE GET E SET
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value; // altero nome para "value" // DESSA FORMA NÃO PRECISAMOS MAIS USAR OS MODELOS GET E SET ABAIXO.
                }
            }
        }

        /*
        public double Preco // AQUI É A IMPLEMENTAÇÃO DE UMA PROPERTY (POSSO DISPENSAR UTILIZANDO A IMPLEMENTAÇÃO LÁ DE CIMA REALIZADA)
        {
            get { return _preco; }
        }
        */

        /*
        public int Quantidade // AQUI É A IMPLEMENTAÇÃO DE UMA PROPERTY (POSSO DISPENSAR UTILIZANDO A IMPLEMENTAÇÃO LÁ DE CIMA REALIZADA)
        {
            get { return Quantidade; }
        }
        */

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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}