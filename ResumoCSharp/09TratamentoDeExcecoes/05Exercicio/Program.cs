using CSharp._09TratamentoDeExcecoes._05Exercicio.Entities.Exception;
using CSharp._09TratamentoDeExcecoes._05Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._09TratamentoDeExcecoes._05Exercicio
{
    internal class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdwarLimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balance, withdwarLimit);

            Console.Write("Enter amount for withdraw: ");
            double amountWithdwar = double.Parse(Console.ReadLine());

            try
            {
                acc.Withdraw(amountWithdwar);
                Console.Write("New Balance: ");
                Console.WriteLine(acc.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Whitdraw error: " + e.Message);
            }
          
        }
    }
}
