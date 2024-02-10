using CSharp._14ExpressoesLambda_Delegates_LINQ._01ComparisonT.Entities;

namespace CSharp._14ExpressoesLambda_Delegates_LINQ._01ComparisonT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Problema

                -Suponha uma classe Product com atributos name e price.
                 Suponha que precisamos ordenar uma lista de objetos Product

                -Podemos implementar a comparação de produtos por meio da implementação da interface IComparable<Product>

                -Entretanto, desta forma nossa classe não fica fechada para alteração: se o critério de comparação mudar, precisaremos 
                 alterar a classe Product.

                -podemos então usar outra sobrecarga do método "Sort" da classe List:
                    public void Sort(Comparison<T> comparison)

                Comparison<Product> é um delegate

                public delegate int Comparison<in T>(T x, T y)//função no system
             */

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));//usa-se outra versão do sort que recebe um Comparison<<T>

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            /*
             - 1
            Comparison<Product> comp = CompareProducts;
            list.Sort(comp); tb funcionaria

            static int CompareProducts(Product p1, Product p2) { 
                return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            }

             - 2
            list.Sort(CompareProducts);

            static int CompareProducts(Product p1, Product p2) { 
                return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            }

            - 3Expressao Lambda
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort(comp);

            -4
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            
            */
        }
    }
}
