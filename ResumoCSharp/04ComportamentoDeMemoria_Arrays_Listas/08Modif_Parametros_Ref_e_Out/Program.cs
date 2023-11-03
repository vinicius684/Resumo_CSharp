using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._08Modif_Parametros_Ref_e_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ref - faz o parâmetro ser uma referência para a variável original
                out - faz o parâmetro ser uma referência para a variável original, mas não exige que a variável original sera iniciada.

                Nota -  ambos são considerados "code smells"(design ruim) e devems er evitados

                Problema 1 - suponha que se queira uma calculadora com uma operação para triplicar o valor de um número como parâmetro
            */

            //ref
            int a = 10;
            Calculadora.Triplicar(ref a);//sem o ref não funcionaria, a função receberia 10 como parametro, executaria e 'a' continuaria apontando par 10
            Console.WriteLine(a);

            //out
            int b = 10;
            int triplo;
            Calculadora.Triplicar2(a, out triplo);
            Console.WriteLine(triplo);

        }
    }
}
