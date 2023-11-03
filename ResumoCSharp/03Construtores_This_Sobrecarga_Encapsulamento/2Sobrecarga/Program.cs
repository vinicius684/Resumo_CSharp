using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento._2Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              =====Sobrecarga=====
               ->Recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém, com diferentes listas de parâmentros
                obs:não só para construtores, mas qualquer método com mesmo nome  
            */

            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco);

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
