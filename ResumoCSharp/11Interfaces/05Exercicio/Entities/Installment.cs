using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._05Exercicio.Entities
{
    internal class Installment //Parcela
    {
        public DateTime DueDate { get; set; } //data de vencimento
        public double InstallmentValue { get; set; }

        public Installment(DateTime dueDate, double installmentValue)
        {
            DueDate = dueDate;
            InstallmentValue = installmentValue;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + InstallmentValue.ToString();
                
        }
    }
}
