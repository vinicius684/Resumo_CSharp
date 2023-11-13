using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._11Interfaces._05Exercicio.Entities;
using CSharp._11Interfaces._05Exercicio.Services;

namespace CSharp._11Interfaces._05Exercicio.Services
{
    internal class PayPalPaymentService : IPaymentService //serviço de pagamento PayPal
    {
        private const double Taxa= 0.02;
        private const double Juros = 0.01;

        public double JurosSimples(double amount, int months)
        {
            return amount * Juros * months;
        }

        public double TaxaDePagamento(double amount)
        {
            return amount * Taxa;
        }
    }
}
