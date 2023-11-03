using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._09Exercicio.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }//rendimento anual

        public Taxpayer() { }

        public Taxpayer(string name, double annualIncome) { 
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();  //metodo abstrato - imposto
        
    }
}
