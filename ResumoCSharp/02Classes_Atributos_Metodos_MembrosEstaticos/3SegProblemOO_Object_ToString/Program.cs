using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._3SegProblemOO_Object_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               ToString - converte o objeto para string dentro da classe
               obs:uma das funções da classe Object
             */
            Produto p1;

            p1 = new Produto();

            p1.Nome = Console.ReadLine();
            p1.Preco = double.Parse(Console.ReadLine());
            p1.Qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p1);

            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int entrada = int.Parse(Console.ReadLine());
            p1.Adicionarprodutos(entrada);
            Console.WriteLine("Dados do Produto: " + p1);


            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int saida = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(saida);
            Console.WriteLine("Dados do Produto: " + p1);

        }
    }
}
