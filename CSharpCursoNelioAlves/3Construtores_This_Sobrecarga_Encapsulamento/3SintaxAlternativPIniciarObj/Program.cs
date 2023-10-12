using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._3Construtores_This_Sobrecarga_Encapsulamento._3SintaxAlternativPIniciarObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto { Nome = "TV", Preco = 500.00, Qtd = 20 };//Forma alternativa de instanciar a classe e atribuir valores aos Atributos
            //necessário estar com o contrutor padrão disponível

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
