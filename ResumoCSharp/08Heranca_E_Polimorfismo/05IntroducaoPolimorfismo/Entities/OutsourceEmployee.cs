using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp._8Heranca_E_Polimorfismo.IntroducaoPolimorfismo.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee(string name, int horas, double valuePeHour, double additionalCharge) : base(name, horas, valuePeHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            
            double AuxPaymentOsE = base.Payment() + (AdditionalCharge * 1.1);
            return AuxPaymentOsE;
        }

        public override string ToString()
        {
            return Name + " - $" + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
