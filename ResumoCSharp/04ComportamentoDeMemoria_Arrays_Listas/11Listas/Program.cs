using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._11Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             =====Lista=====
                 *Estrutura de dados homogênea(dados do mesmo tipo)
                 *Ordenada(elementos do mesmo tipo)
                 *Inicia vazia, e seus elementos são alocados sob demanda
                 *Cada elemento ocupa um "nó" da lista("seta" que indica o próximo espaço de memória(sequencial))

                  Classe: List    
                  Namespace:System.Collection.Generic

                 ->Vantagens: Tamanho variável, Facilidade para se realizar inserções e deleções
                 ->Desvantagens: Acesso sequencial aos elementos *
             */

            List<string> list = new List<string>();

            List<string> list2 = new List<string>() { "Maria", "Alex" };

        }
    }
}
