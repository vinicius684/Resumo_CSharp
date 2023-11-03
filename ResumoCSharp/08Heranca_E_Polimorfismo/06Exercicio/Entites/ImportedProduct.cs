using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._06Exercicio.Entites
{
    internal class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct(string nome, double price, double customsFree) : base(nome, price) { 
                CustomsFree = customsFree;
        }

        public override string PriceTag()
        {
            return Nome + " $" + Price + "(Customs Free: $" + CustomsFree + ")";
        }

        public double TotalPrice() {
            return Price + CustomsFree;
        }
    }
}
