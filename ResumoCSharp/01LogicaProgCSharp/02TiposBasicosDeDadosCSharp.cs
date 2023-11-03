using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LogicaProgCSharp
{
    class TiposBasicosDeDadosCSharp
    {
        static void Main(string[] args)
        {
            bool completo = false;

            char genero = 'F';
            char letra = '\u0046';//F em código unicode

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;

            float n5 = 4.5f;
            double n6 = 4.5;

            string nome = "Maria Juana";

            object obj1 = 4.8f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);

        }

    }
}
