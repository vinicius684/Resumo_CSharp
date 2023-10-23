using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._3Construtores_This_Sobrecarga_Encapsulamento._7AutoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               =====Auto Propeties=====
                ->É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as  operações 
                get e set.
                ->Atalho - prop tab tab
             */

            Produto p1 = new Produto("TV", 500.00, 10);

            p1.Nome = "Tablet";
            Console.WriteLine(p1.Nome);

            Console.WriteLine(p1.Preco);

            Console.WriteLine(p1.Qtd);

            p1.Adicionarprodutos(5);
        }
    }
}
