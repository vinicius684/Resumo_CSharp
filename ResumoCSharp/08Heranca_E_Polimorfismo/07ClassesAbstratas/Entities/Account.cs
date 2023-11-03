using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._07ClassesAbstratas.Entities
{
        abstract class Account
        {
            public int Number { get; private set; }
            public string Holder { get; private set; }
            public double Balance { get; protected set; }//protected - Atributo pode ser alterado dentro da propria classe ou subclasse (Herança), mas não pode na Main, por exemplo

            public Account()
            {
            }

            public Account(int number, string holder, double balance)
            {
                Number = number;
                Holder = holder;
                Balance = balance;
            }

            public virtual void Whitdraw(double amount)//metodo sobreposto na SavingAccount, lá não tem 5 reais de taxa
            {
                Balance = Balance - (amount + 5);
            }

            public void Deposit(double amount)
            {
                Balance = Balance + amount;
            }
        }
}
