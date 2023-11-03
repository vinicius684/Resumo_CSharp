using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) { 
            Name = name;
            Price = price;
        }
    }
}
