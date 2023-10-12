using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._3Construtores_This_Sobrecarga_Encapsulamento._2Sobrecarga
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto() { }//quando uso construtores com argumentos e quero usar o Padrão, devo implementa-ló

        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public Produto(string nome, double preco)//Sobrecarga
        {
            Nome = nome;
            Preco = preco;
            Qtd = 5; //posso retirar ou já inicia-lo com algum valor 
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
