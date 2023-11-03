using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._10Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             =====Laço for each=====
                Sintaxe opcional e simplificada para percorrer coleções 
                Leitura:"Para cada objeto 'obj' contido em vect, faça"
             */

            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            /*for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }*/

            foreach (string obj in vect)
            {//tipo do vetor, apelido para os itens in nome vetor
                Console.WriteLine(obj);
            }

        }
    }
}
