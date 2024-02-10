using CSharp._14ExpressoesLambda_Delegates_LINQ._05Predicate.Entities;
using System.Collections.Generic;

namespace CSharp._14ExpressoesLambda_Delegates_LINQ._05Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               =====Predicate (System)=====
               -Representa um método que recebe um objeto do tipo T e retorna um valor booleano
             */

            /*
               Demo
               -Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo  
               preço mínimo seja 100.
             */

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0); //produto p, tal que p.Price seja maior ou igual a 100
            list.RemoveAll(ProductTest);//Esse método tem comoa argumento um predicate
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
        public static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }
    }
}
