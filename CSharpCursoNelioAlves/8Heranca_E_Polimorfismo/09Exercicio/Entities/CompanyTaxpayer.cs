using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._09Exercicio.Entities
{
    internal class CompanyTaxpayer : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public CompanyTaxpayer(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double imposto = 0;
            if (NumberOfEmployees > 10) {
                imposto = AnnualIncome * 0.14;
            }
            else {
                imposto = AnnualIncome * 0.16;
            }
            return imposto;
        }
    }
}
