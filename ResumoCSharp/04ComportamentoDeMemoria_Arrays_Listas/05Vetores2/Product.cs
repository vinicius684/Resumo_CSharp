using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._05Vetores2
{
    internal class Product
    {
        public string Name { get; set; }
        public double Preco { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Preco = price;
        }

        public override string ToString()
        {
            return Name + " " + Preco;
        }
    }
}
