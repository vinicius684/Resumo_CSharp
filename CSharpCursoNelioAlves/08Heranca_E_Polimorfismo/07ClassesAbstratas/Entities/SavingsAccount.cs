using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._07ClassesAbstratas.Entities
{
    internal class SavingsAccount : Account
    {
        //counta poupança - atributo taxa de juros
        public double InterstRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            interestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance = Balance + (Balance * InterstRate);
        }
        /*
        public override void Whitdraw(double amount)//não tem taxa, no metodo da superclasse tem taxa
        {
            Balance = Balance - amount; 
        }
        */
        public override void Whitdraw(double amount)
        {
            base.Whitdraw(amount);//aproveitar o metodo da superclasse
            Balance = Balance - 2;
        }

    }
}
