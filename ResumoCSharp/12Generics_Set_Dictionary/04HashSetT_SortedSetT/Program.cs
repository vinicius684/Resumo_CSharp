using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._12Generics_Set_Dictionary._04HashSetT_SortedSetT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====HashSet<T> e SortedSet<T>=====
                -Representa um conjunto de elementos (similar ao da Algebra)
                    -Não admite repetições
                    -Elementos não possuem posição
                    -Acesso, inserção e remoção de elemtnso são rápidos
                    -Oferece operações eficientes de conjunto: interseção, união, diferença

                -Se a ordem dos elementos é não importante, usa-se HashSet 

                -Em alguns problemas vai ser interessante não ter repetições no conjunto, por isso não utilizar List. 
                 Union e Intersection, por exemplo, não são eficientes em Lista
             */

            /*
                -HashSet
                    -Armazenamento em table hash
                    -Extremamente rápido:inserção, remoção e busca O(1)
                    -A ordem dos elementos não é garantida - A impressão não vai sair necessáriamente na ordem que inseriu
             */
            /*
                -SortedSet
                    -Armazenamento em árvore
                    -Rápido:inserção, remoção e busca O(log(n)) 
                    -Os elementos são armaenados ordenadamente confome implementação IComparer<T>
             */

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach(string item in set)//for não faz tanto, HS e ST não tem posição 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===========================================Parte2======================================================");

            SortedSet<int> a = new SortedSet<int>() {0,2,4,5,6,8,10 };
            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10 };

            PrintCollection(a);

            //union
            SortedSet<int> c = new SortedSet<int>(a);//contrutor SS que pega os elementos de outra coleção e insere dentro dele
            c.Union(b);//elementos não repetidos apenas
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);//elementos que repetem nos dois conjuntos
            PrintCollection(d);

            //Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) { //Função recebendo argumento Genérico do Tipo T que implementa o IEnumerable(disponibiliza uma forma de percorrer a coleção)
            foreach(T item in collection) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
