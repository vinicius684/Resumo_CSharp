using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento._7AutoProperties
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }//autopropetie
        public int Qtd { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Qtd = quantidade;
        }

        public string Nome //Propertie
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Qtd + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
