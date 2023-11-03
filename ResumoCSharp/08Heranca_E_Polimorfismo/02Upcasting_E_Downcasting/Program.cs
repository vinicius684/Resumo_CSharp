using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8Heranca_E_Polimorfismo._02Upcasting_E_Downcasting.Entities;

namespace CSharp._8Heranca_E_Polimorfismo._02Upcasting_E_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             -Upcasting
                *Cating da subclasse para superclasse (ex: converter um objeto do tipo BusinessAccount para Account)
                *Uso coomum: polimorfismo

             -Downcasting
                *Casting da superclasse para subclasse (ex: converter um objeto do tipo  Account para BusinessAccount)
                *Palavra as
                *Palavra is
                *Uso comum: métodos que recebem parametros genéricos(ex:Equals)
             */

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = bacc; //o compilador aceita - o bussines account 'é um' account
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING - Operacao Insegura  

            BusinessAccount bacc1 = (BusinessAccount)acc2; // Bacc recebe Acc - OK
            bacc1.Loan(100.0);

            //=============BusinessAccount acc5 = (BusinessAccount)acc3;  Bacc recebe Sacc - Erro============
            if (acc3 is BusinessAccount) {
                BusinessAccount acc5 = (BusinessAccount)acc3; 
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            //outra forma de fazer casting BussinessAccount acc5 = acc3 as BussinessAccount; = BusinessAccount acc5 = (BusinessAccount)acc3; 
        }
    }
}
