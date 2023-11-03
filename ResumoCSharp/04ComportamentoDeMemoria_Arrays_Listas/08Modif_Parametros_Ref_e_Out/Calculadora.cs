using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._08Modif_Parametros_Ref_e_Out
{
    internal class Calculadora
    {
        //ref
        public static void Triplicar(ref int x)
        {//sem o ref não funcionaria
            x = x * 3;
        }

        //out
        public static void Triplicar2(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
