using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._1LogicaProgCSharp
{
    internal class _11OperadoresLogicos
    {
        static void Main(string[] args)
        {
            /*                     precedencia
                 ||         ou      3
                 &&         e       2
                  !         não     1
             */

            bool c1 = 2 > 3 || 4 != 5; // F  ou  V   =  V

            bool c2 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("-----------------");

            bool c3 = 10 < 5;

            bool c4 = c1 || c2 && c3;// c2 && c3 será resolvido primeiro = V

            Console.WriteLine(c4);
        }
    }
}
