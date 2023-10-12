using System;

namespace CSharpCursoNelioAlves._1LogicaProgCSharp
{
    class _7OperadoresAritmeticos
    {
        static void Main(string[] args)
        {
            /*          ordem de precedência cima para baixo
                %  
                /
                *
                -
                +
             */

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("*********************Baskara**********************");

            double a = 1.0, b = -3.0, c = -4.0;

            //double delta = b * b - 4.0 * a * c;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;//elevado

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);//raiz quadrada
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
