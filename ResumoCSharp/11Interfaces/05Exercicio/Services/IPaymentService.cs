using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._05Exercicio.Services
{
    interface IPaymentService 
    {
        double TaxaDePagamento(double amount);
        double JurosSimples(double amount, int months); 
    }
}
