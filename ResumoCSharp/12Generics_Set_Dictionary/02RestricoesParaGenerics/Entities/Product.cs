using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp._12Generics_Set_Dictionary._02RestricoesParaGenerics.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product)){
                throw new ArgumentException("Comparing erro: argument is not a Product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
