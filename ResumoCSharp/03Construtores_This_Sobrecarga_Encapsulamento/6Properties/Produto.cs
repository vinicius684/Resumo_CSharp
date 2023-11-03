using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento._6Properties
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _qtd;
        //public int Qtd; -> dessa fora a classe permite que eu troque a revelia a quantidade, o certo seria trocar apenas pelas operação


        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _qtd = quantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Qtd
        {
            get { return _qtd; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _qtd;
        }

        public void Adicionarprodutos(int quantidade)
        {
            _qtd = _qtd + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _qtd = _qtd - quantidade;
        }

        //override - sobreposição - usar uma função de outra classe, no caso ToString()
        public override string ToString()
        {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _qtd + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
