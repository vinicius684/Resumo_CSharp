using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._1LogicaProgCSharp
{
    class _9EntradaDeDados2
    {
        static void Main(string[] args)
        {
            /*
                Castings por conta da entrada de dados retornar um valor String     
             */

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//cultureInfo.Inv... tb para entrada de dados

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            /**************Split****************/

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
