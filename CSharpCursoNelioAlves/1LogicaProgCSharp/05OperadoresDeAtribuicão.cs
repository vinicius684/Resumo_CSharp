using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._1LogicaProgCSharp
{
    class _5OperadoresDeAtribuicão
    {
        static void Main(string[] args)
        {
            /**
                 =
                +=
                -=
                *=
                /=
                %=
             **/

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            //+= tb funciona pra string

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);


            Console.WriteLine("-------------------");
            /** Operador aritméticos / atribuição
                ++ incremento - antes ou após(a++ ou ++a)
                -- decremento - antes ou após(a-- ou --a)
             **/

            int x = 10;
            int y = x++;//y recebe o valor de x e só depois x é incrementado
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 10;
            y = ++x;//y recebe o valor de x já incrementado
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}
