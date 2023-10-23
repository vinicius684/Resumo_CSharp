using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._1LogicaProgCSharp
{
    internal class ExFor
    {
        /*1-valores impares de 0 até o núumero digitado
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= x; i++) { 
              if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

        /*2-Digitar números e ver quantos estão dentro ou fora do intervalo
        int N = int.Parse(Console.ReadLine());
        int X = 0;
        int dentro = 0;
        int fora = 0;

        for (int i = 0; i <= N; i++) {
           X = int.Parse(Console.ReadLine());
            if (X >= 10 && X <= 20)
            {
                dentro++;
            }
            else { 
                fora++;
            }
        }
        Console.WriteLine(dentro + "int, " + fora + "out");
        */

        /*3-Fatorial de um número
        int N = int.Parse(Console.ReadLine());
        int fat = 1;
        for (int i = N;i != 0; i--) {
            fat = fat * i;
        }
        Console.WriteLine(fat);
        */

        /*4 - 
        int N = int.Parse(Console.ReadLine()); ;
        for (int i = 1; i <= N; i++) {
            Console.Write(i);
            Console.Write(i*i);
            Console.WriteLine(i*i*i);
        }
        */
    }
}
