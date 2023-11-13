
using System.Globalization;

namespace CSharp._11Interfaces._02ExSemInterface.Entites
{
    internal class Invoice // fatura
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment { //atributo 
            get { return BasicPayment + Tax; } 
        }

        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) 
                + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture) 
                + "\nTotal payment: " + TotalPayment.ToString(CultureInfo.InvariantCulture);
        }
    }
}
