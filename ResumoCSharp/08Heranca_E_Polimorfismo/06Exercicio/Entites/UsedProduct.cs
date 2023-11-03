using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._06Exercicio.Entites
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string nome, double price, DateTime manufactureDate) : base(nome, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Nome + " (used) $" + Price + "(Manufacture date: " + ManufactureDate + ")";
        }

        
    }
}
