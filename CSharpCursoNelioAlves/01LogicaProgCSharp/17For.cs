using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._1LogicaProgCSharp
{
    internal class _17For
    {
        static void Main(string[] args)
        {
            /*
              for(inicio;condicao;incremento){
                 comando1;
                 comando2;
             }
            usada quando sabemos o número de repetições previamente(geralmente)
             */
            Console.Write("Quantos números inteiros vc vai digitar?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor" + i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
