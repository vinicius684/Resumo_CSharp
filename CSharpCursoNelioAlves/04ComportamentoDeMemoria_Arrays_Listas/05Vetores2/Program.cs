using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._4ComportamentoDeMemoria_Arrays_Listas._05Vetores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Uso de vetores no tipo classe
               Ex:Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produto. Armazene os N produto em um vetor.
                  Em seguida, mostrar o preço médio dos produtos.
             */
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(nome, preco);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            double media = sum / n;
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine(vect[1]);//Teste

        }
    }
}
