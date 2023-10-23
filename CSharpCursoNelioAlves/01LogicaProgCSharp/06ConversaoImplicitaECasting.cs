using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._1LogicaProgCSharp
{
    class _6ConversaoImplicitaECasting
    {
        static void Main(string[] args)
        {
            //conversão implicita ex: double recebe um valor float, porque é maior/mesmo tipo
            //conversão explicita(casting) ex: float não recebe um valor double, porque é menor, logo precisa de casting

            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a;
            c = (int)b;

            /******************/

            int x = 5;
            int y = 2;

            double resultado = (double)x / y;//caso contrário o resultado daria 2

            Console.WriteLine(resultado);

        }
    }
}
