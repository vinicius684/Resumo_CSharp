using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._12Listas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //==========Inserção==========
            list.Add("João");//Inserir no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(2, "Marco");//inserir em uma posição especifica(Lembrando: começa no indice 0)==

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-----------");

            //==========Tamanho da lista==========
            Console.WriteLine("Tamanho da lista: " + list.Count);
            Console.WriteLine("-----------");

            //==========Encontrar==========
            //'->Essas funções esperam um bool como argumento para retornar o item, possível resolver com função ou expressão lambda(mais indicado)

            //Encontrar primeiro elemento da lista que satisfaça um predicado
            //string s1 = list.Find(Test); com função
            string s1 = list.Find(x => x[0] == 'A');//objeto x, tal que x na posição 0, seja = 'A'
            Console.WriteLine("First 'A': " + s1);

            //Encontrar último elemento da lista que satisfaça um predicado
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //Encontrar primeiro posição do elemento da lista que satisfaça um predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //Encontrar última posição do elemento da lista que satisfaça um predicado
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);
            Console.WriteLine("-----------");

            //==========Filtrar(com base em um predicado)==========
            //'->Criar uma nova lista contendo apenas elementos que satisfaçam o predicado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------");

            //==========Remover==========
            //Remover um item especifico
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------");

            //A partir da posição dois,Remover dois elementos
            list.RemoveRange(2, 2);
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------");

            //Remover um item a partir do indice
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------");

            //Remover todos os itens de acordo com um predicado
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
