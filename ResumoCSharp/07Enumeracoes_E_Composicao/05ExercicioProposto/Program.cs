using CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities.Enums;
using CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities.Enums;
using CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities;

namespace CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.WriteLine("Name:");
            string clientNome1 = Console.ReadLine();
            Console.WriteLine("Email:");
            string email1 = Console.ReadLine();
            Console.WriteLine("Birth date:");
            DateTime bDate1 = DateTime.Parse(Console.ReadLine());

            Client client1 = new Client(clientNome1,email1,bDate1);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus1 = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine("How many items to this order?");
            double nProdutos = double.Parse(Console.ReadLine());

            Order order1 = new Order(orderStatus1, client1);

            for (int i = 1;  i <= nProdutos; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.WriteLine("Product Name:");
                string productNome = Console.ReadLine();
                Console.WriteLine("Product Price");
                double productPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity:");
                int qtd = int.Parse(Console.ReadLine());
                order1.AddItem(new OrderItem(qtd, productPrice, new Product(productNome, productPrice)));
            }

            Console.WriteLine(order1);
            //Console.WriteLine(order1.OrderItem[0].Product.Name);

        }
    }
}
