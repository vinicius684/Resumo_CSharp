using CSharp._14ExpressoesLambda_Delegates_LINQ._06Action.Entities;

namespace CSharp._14ExpressoesLambda_Delegates_LINQ._06Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action (System) - Representa um método void que recebe 0 ou mais argumentos

            /*
             Demo
             -Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos em 10%.
             */

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            //list.ForEach(UpdatePrice); //recebe um argumento action do tipo Product - Ou seja, uma função que receba um Produto e que seja void

            //Action<Product> act = UpdatePrice;   //pode receber até  16 argumentos de tipo<Product, Client, ...>
            //list.ForEach(act);

            //Action<Product> act = p => { p.Price += p.Price * 0.1; }; 
            //list.ForEach(act);

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }
    }
}
