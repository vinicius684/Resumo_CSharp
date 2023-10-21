using CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._06Exercicio.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._06Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();
            Console.Write("Enter the number of products: ");
            int nProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nProducts; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, Used or imported (c/u/i)?");
                char c_u_i = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (c_u_i == 'c')
                {
                    listProducts.Add(new Product(name, price));
                }
                else if (c_u_i == 'u')
                {
                    Console.Write("Manufacture Date  (DD/MM/YYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    listProducts.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (c_u_i == 'i')
                {
                    Console.Write("Customs free: ");
                    double customsFree = double.Parse(Console.ReadLine());
                    listProducts.Add(new ImportedProduct(name, price, customsFree));
                }
                else {
                    Console.Write("Esse tipo de produto não existe, produto não adicionado");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Price Tags:");
            foreach (Product obj in listProducts)
            {
                Console.WriteLine(obj.PriceTag()); 
            }

        }
    }
}
