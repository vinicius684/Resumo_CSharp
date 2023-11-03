using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._10TrabalhandoComArquivos.Exercicio.Entities
{
    internal class DocEntrada
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public DocEntrada(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double Total() { 
            return Preco * Quantidade;
        }
    }
}
