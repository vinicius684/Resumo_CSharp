using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento._6Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               =====Properties=====//tornoar obter e definir(atualizar) os atributos mais seguro.
                ->São definições de métodos encapsuados, porém expondo uma sintaxe similar à de atributos e não de métodos
                ->Uma propetie é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular. As
                propriedades podem ser usadas como se fossem atributos públicos, mas na verdade elas são métodos especiais chamados 
                "acessadores". Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos 
                métodos.
                Nota: Propeties = 'Encapsulamento utilizado de forma a garatir mais praticidade'
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
