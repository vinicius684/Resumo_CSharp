using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._5TopicosEspeciaisEmCSharp_Pt1
{
    internal class _3ExpressaoCondicionalTernaria
    {
        static void Main(string[] args)
        {
            /*
             Estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição

            (condição) ? valor_se_verdadeiro : valor_se_falso
             */

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.5;

            double valorFinal = preco - desconto;

            Console.WriteLine(valorFinal);


        }
    }
}
