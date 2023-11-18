using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._12Generics_Set_Dictionary._03GetHashCode_Equals.Entities;

namespace CSharp._12Generics_Set_Dictionary._03GetHashCode_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====GetHashCode e Equals=====
                -São operações da classe Object utilizadas para comparar se um objeto é igual a outro

                -Equals:lento, resposta 100%
                -GetHashCode:rápido, porém resposta positiva não é 100%

                -Os tipos pré definidos jápossuem implementação para essas operações. Classes e Structs precisam sobrepô-las
             */

            /*
              Equals - método que compara se o objeto(valor dele) é igual a outro retornando true ou false
                string a = "Maia";
                string b = "Alex";

                Console.WriteLine(a.Equals(b));
             */


            /*
                GetHashCode - Método que retorna um número inteiro representando um código gerado a partir das informações do objeto
                -Se o código de dois objetos for diferente, então os dois objetos são diferente    
                -Se o código de dois objetos for igual, muito provavelmente os dois objetos são iguais(pode haver colisão) 
                    Console.WriteLine(a.GetHashCode());
                    Console.WriteLine(b.GetHashCode());
             */

            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));//compara se o conteúdo é igual
            Console.WriteLine(a == b); //compara a referencia de memória
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }

}

