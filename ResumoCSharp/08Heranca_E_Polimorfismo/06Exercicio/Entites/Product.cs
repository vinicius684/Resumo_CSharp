using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._06Exercicio.Entites
{
    internal class Product
    {
        public string Nome { get; set; } = "";
        public double Price { get; set; } = 0;

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }

        public virtual string PriceTag() {
            return Nome + " $" + Price; 
        }
    }
}
