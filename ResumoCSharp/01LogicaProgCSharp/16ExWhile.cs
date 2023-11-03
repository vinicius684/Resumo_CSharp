using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._1LogicaProgCSharp
{
    internal class _16ExWhile
    {
        static void Main(string[] args)
        {
            int produto = 0;
            int um = 0;
            int dois = 0;
            int tres = 0;

            Console.WriteLine("Digite os produtos \n 1.Alcol \n 2.Gasolina \n 3.Diesel \n 4.Fim");
            while (produto != 4)
            {
                produto = int.Parse(Console.ReadLine());
                if (produto == 1)
                {
                    um = um + 1;
                }
                else if (produto == 2)
                {
                    dois = dois + 1;
                }
                else if (produto == 3)
                {
                    tres = tres + 1;
                }

            }

            Console.WriteLine("Obrigado");
            Console.WriteLine("Alcool " + um + "; Gasolina" + dois + "; Diesel" + tres);
        }
    }
}