using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._4ComportamentoDeMemoria_Arrays_Listas._07Modif_Parametros_Params
{
    internal class Calculadora
    {
        public static int Sum(params int[] numbers)//metodo
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
