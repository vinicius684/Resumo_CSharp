using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._1LogicaProgCSharp
{
    class _8EntradaDeDados
    {
        static void Main(string[] args)
        {
            /*
                Console.ReadLine();
                    Lê a entrada padrão até a quebra de linha
                    Retorna os dados lidos na forma de string 
            */

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: " + frase);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("***********Split************");//digitar tudo em um unico Console.Read e guardar cada palavra em uma variável

            //string s =  Console.ReadLine();
            //string[] vet = s.Split(' ');

            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
