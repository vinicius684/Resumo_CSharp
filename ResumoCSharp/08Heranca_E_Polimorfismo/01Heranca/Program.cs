using CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities;
using CSharp._8Heranca_E_Polimorfismo._01Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8Heranca_E_Polimorfismo._01Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             =====Herança=====
                -Tipo de associação que permite que uma classe herde dados e comportamentos de outra
                -Vantagens: Reuso, Polimorfismo
                -Sintaxe: :(estende), base(referência para a superclasse)
             */
            BusinessAccount businessAccount = new BusinessAccount();

            Console.WriteLine(businessAccount.Balance);
        }
    }
}
