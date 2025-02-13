using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto02
{
    public class Produto
    {
        public string Nome; // Atributos sempre começam com letra maiúscula
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() // Método 1
        {
            return Preco * Quantidade; // METODO DE VALOR TOTAL EM ESTOQUE
        }

        public void AdicionarProdutos(int quantidade) // void é vazio, nao vai ser retornado nada para a program
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() // Assinatura basica da função do ToString, override significa que a operação vem de outra classe,
        {                                 // string porque é o tipo de saída do método
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
