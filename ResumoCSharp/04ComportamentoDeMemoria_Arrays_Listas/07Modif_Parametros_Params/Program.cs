using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._07Modif_Parametros_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //suponha que se queira uma calculadora para calcular a soma de uma quantidade variável de valores. Solução ruim usando sobrecarga
            int s1 = Calculadora.Sum(2, 3);
            int s2 = Calculadora.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
