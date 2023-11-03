using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento._4This
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;


        public Produto()
        {
            Qtd = 10;
        }
        public Produto(string nome, double preco) : this()//"reaproveitando o contrutor anterior"
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)//"reaproveitando o contrutor anterior"
        {
            Qtd = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void Adicionarprodutos(int quantidade)
        {
            Qtd = Qtd + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qtd = Qtd - quantidade;
        }

        //override - sobreposição - usar uma função de outra classe, no caso ToString()
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Qtd + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
