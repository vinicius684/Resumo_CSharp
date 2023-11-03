using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._1LogicaProgCSharp
{
    internal class _15While
    {
        static void Main(string[] args)
        {
            /*
             while(condição){
                  comando 1;
                  comando 2;
              }
             */
            double valor = 1.0;

            while (valor >= 0)
            {
                Console.Write("Digite um número");
                valor = double.Parse(Console.ReadLine());

                double raizQuad = Math.Sqrt(valor);
                Console.WriteLine("Raíz quadrada: " + raizQuad.ToString("F3", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Número negativo");
        }
    }
}
