using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._03Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              =====Nulable=====
                ->É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null
                ->Uso Comum:    
                    *Campos de branco de dados que podem valor nulo (data de nascimento, algum valor numérico, etc).
                    *Dados e parâmetros opcionais
            */

            //double x = null; Erro
            //Nullable<double> x = null; Existe uma forma mais simplificada de fazer isso
            double? x = null;

            Console.WriteLine(x.GetValueOrDefault());//Obter valor ou default(caso não tenha/seja nulo)

            Console.WriteLine(x.HasValue);//booliano de se existe valor 

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is null");
            }


            //==================Operador de coalescência nula===========================

            double y = x ?? 4.0;//y recebe o valor de x e se caso x for nulo, y receberá 4.0
            Console.WriteLine(y);
        }
    }
}
