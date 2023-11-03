using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo.Classe_Selada
{
    sealed class SavingsAccount : Account
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

        public sealed override void Whitdraw(double amount)//sealed, essa operacao não pode ser sobreposta novamente em outra classe
        {
            Balance = Balance - amount;
        }
    }
}
