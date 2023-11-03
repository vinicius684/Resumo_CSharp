using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._5TopicosEspeciaisEmCSharp_Pt1
{
    class _2SintaxeAlternativa_SwitchCase
    {
        static void Main(string[] args)
        {
            /*
             =====Switch Case=====
               Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste do valor de uma variável
             */

            int x = int.Parse(Console.ReadLine());
            string day;

            /* if (x == 1)
             {
                 day = "Domingo";
             }
             else if (x == 2)
             {
                 day = "Segunda";
             }
             else if (x == 3)
             {
                 day = "terça";

             }
             else if (x == 4)
             {
                 day = "quarta";

             }
             else {
                 day = "valor invalido";
             }*/

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda";
                    break;
                case 3:
                    day = "Terça";
                    break;
                case 4:
                    day = "Quarta";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);

        }
    }
}
