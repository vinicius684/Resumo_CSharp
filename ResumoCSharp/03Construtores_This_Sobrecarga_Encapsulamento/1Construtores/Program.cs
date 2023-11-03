using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento.Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              =====Contrutor=====
               ->Operação especial da classe, que executa no momento da instanciação do objeto
               ->Uso Comum: *Iniciar valores dos atributos; *Permitir ou obrigar que o objeto receba dados/dependências 
                 no momento de sua instanciação(injeção de dependência)
               ->Se um cosntrutor customizado não for especificado, a classe disponibiliza o construtor padão: Produto p = new Produto();
               ->É possível especificar mais de um cosntrutor na mesma classe(sobrecarga)  
            */


            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine());
            int qtd = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, qtd);//contrutor, antes precisava ficar acessando os atributos para colocar valor, agora os valores já são atribuidos na hora da instanciação

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
