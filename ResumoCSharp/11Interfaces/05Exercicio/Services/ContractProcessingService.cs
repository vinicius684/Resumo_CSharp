using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._11Interfaces._05Exercicio.Entities;
using CSharp._11Interfaces._05Exercicio.Services;

namespace CSharp._11Interfaces._05Exercicio.Services
{
    internal class ContractProcessingService //Processamento do Contrato
    {
        private IPaymentService _paymentService;

        public ContractProcessingService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double parcelaBasica = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double valorComJuros = parcelaBasica + _paymentService.JurosSimples(parcelaBasica, i);
                double valorComJurosMaisTaxa = valorComJuros + _paymentService.TaxaDePagamento(valorComJuros);
                contract.AddInstallments(new Installment(date, valorComJurosMaisTaxa));
            }
        }
    }
}
