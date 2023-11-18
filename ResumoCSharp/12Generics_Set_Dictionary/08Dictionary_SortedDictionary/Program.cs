using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._12Generics_Set_Dictionary._08Dictionary_SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====Dictionary<TKey,TValue>=====
                -Coleção de pares chave/valor
                    -Não admite repetições do objeto chave
                    -Os elementos são indexados pelo objeto chave(não possuem posição)
                    -Acesso, inserção e remoção de elementos são rápidos

                -Uso comum: cookies, local sotrage, qualquer modelo chave-valor

                -Em outras linguagens geralmente tem nome de Map
             */

            /*
                 Dictionary
                    -Armazenamento em tabela hash
                    -Extremamente rápido:inserção, remoção e busca O(1)
                    -A ordem dos elementos não é garantida

                SortedDictionary
                    -Armazenamento em árvore
                    -Rápido: inserção, remoção e busca O(log(n))
                    -Os elementos são armazenados ordenadamente conforme implementação IComparer<T>
            */

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria"; //cookies na chave "user", recebe valor "Maria"
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";//sobrescreveu

            Console.WriteLine(cookies["phone"]);

            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            foreach (KeyValuePair<string, string> item in cookies) //para cada item do tipo KeyValuePair<string, string>, dentro de cookies. (var item in cookies) tb funciona.
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
