using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._06ExVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AluguelQuartosAlunos[] vect = new AluguelQuartosAlunos[10];

            Console.Write("Quantos estudantes vão alugar quarto?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new AluguelQuartosAlunos(nome, email);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }
                else { }
            }

        }
    }
}
