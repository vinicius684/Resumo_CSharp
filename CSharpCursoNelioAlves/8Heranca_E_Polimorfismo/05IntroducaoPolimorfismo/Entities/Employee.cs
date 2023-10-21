using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo.IntroducaoPolimorfismo.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Horas { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int horas, double valuePeHour) { 
            Name = name;
            Horas = horas;
            ValuePerHour = valuePeHour;
        }

        public virtual double Payment() { 
            return Horas * ValuePerHour;
        }

        public override string ToString()
        {
            return Name + " - $" + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
