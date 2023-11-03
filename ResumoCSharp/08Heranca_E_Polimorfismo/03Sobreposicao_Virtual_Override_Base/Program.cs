using CSharp._8Heranca_E_Polimorfismo._03Sobreposicao_Virtual_Override_Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._03Sobreposicao_Virtual_Override_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             =========Sobreposição ou sobreescrita=========
                  -É a implementação de um método de uma superclasse na subclasse
                  -Para que um método comum(não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual"
                  -Ao sobrescrever um método, devemos incluir nele o prefixo "override"
             */

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Whitdraw(10);
            acc2.Whitdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            /*
             =========Palavra Base=========
                  -É possível chamar a implementação da superclasse usando a palavra base.
                    Ex: suponha que a reagra para saque para conta pupança seja realizar o saque normalmente da superclasse(Account), e deois descontar mais 2.0
                    public override void Witdraw(double amout){
                        base.Withdraw(amount);
                        Balance -= 2.0;
                    }
             */
        }
    }
}
