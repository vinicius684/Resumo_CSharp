using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._07ClassesAbstratas.Entities;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._07ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====Classes Abstratas=====
                  -São classes que não podem ser -- instanciada ---, mas continuo podendo usar o Tipo da superclasse

                  -É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas, 
                   mas nunca a superclasse abstrata

                  - abstract class Account{  }

                  -Notação UML: Nome da classe em itálico
             */

            // Account acc1 = new Account(1001, "Alex", 500.0); erro 
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001,"Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach(Account account in list)
            {
                sum += account.Balance;
            }
            Console.WriteLine(sum);
            
            foreach (Account account in list) {
                account.Whitdraw(10.0);
            }
            foreach (Account account in list)
            {
                Console.WriteLine(account.Number + " - " + account.Balance);
            }

        }
    }
}
