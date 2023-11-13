using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._11Interfaces._05Exercicio.Entities;
using CSharp._11Interfaces._05Exercicio.Services;

namespace CSharp._11Interfaces._05Exercicio
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            Console.WriteLine("Enter number of installments: ");
            int numInstallments = int.Parse(Console.ReadLine());

            ContractProcessingService cPS = new ContractProcessingService(new PayPalPaymentService());

            cPS.ProcessContract(contract, numInstallments);

            Console.WriteLine("Installments: ");
            foreach (Installment aux in contract.Installments)
            {
                Console.WriteLine(aux);
            }
        }
    }
}
