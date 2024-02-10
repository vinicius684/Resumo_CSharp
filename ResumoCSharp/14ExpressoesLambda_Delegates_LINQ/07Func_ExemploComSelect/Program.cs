using CSharp._14ExpressoesLambda_Delegates_LINQ._07Func_ExemploComSelect.Entities;
using System.Linq;

namespace CSharp._14ExpressoesLambda_Delegates_LINQ._07Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func (System) - Representa um método que recebe zero ou mais argumentos, e retorna um valor  
            //Select - pega uma colecao e tranforma em outra

            /*
             Demo
             -Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos 
             produtos em caixa alta.
             */

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //List<String> result = list.Select(NameUpper).ToList(); //select - recebe de argumento um Func

            //Func<Product, string> func = NameUpper; //Delegate que vai ser a referência para um função que recebe um produt e retorna um string - até 16 argumentos
            //List<String> result = list.Select(func).ToList();

            //Func<Product, string> func = p => p.Name.ToUpper(); //quanto retorna valor não precisa das chaves { }
            //List<String> result = list.Select(func).ToList();

            List<String> result = list.Select(p => p.Name.ToUpper()).ToList(); 
            foreach(String s in result)
            {
                Console.WriteLine(s);
            }
        }
        static string NameUpper(Product p) { 
            return p.Name.ToUpper();
        }
    }
}
