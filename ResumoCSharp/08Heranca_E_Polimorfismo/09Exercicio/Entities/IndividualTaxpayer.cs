using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._09Exercicio.Entities
{
    internal class IndividualTaxpayer : Taxpayer
    {
        public double HealthSpending { get; set; } //gasto com saúde

        public IndividualTaxpayer(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            double imposto = 0;
            if (AnnualIncome < 20000)
            {
                imposto = AnnualIncome * 0.15 - (HealthSpending * 0.5);
            }
            else
            {
                imposto = AnnualIncome * 0.25 - (HealthSpending * 0.5); ;
            }
            return imposto;
        }
    }
}
