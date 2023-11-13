using CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities;
using CSharp._7Enumeracoes_E_Composicao._04Exercicio_StringBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._05Exercicio.Entities
{
    internal class Contract //Contrato
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallments(Installment installments) {
            Installments.Add(installments);
        }        

    }
}
