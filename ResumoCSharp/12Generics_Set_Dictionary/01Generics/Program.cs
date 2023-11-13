using CSharp._12Generics_Set_Dictionary._01Generics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._12Generics_Set_Dictionary._01Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ===== Generics===== 
                -Permitem que classes, interfaces e métodos possam ser parametrizados por tipo. 
                -Seus benefícios são: Reuso; Type safety; Performance
                -Uso Comum: Coleções

                List<string> list = new List<string>();
                list.Add("Maria");
                string nome = list[0];

                PrintService implementado sem Generics, leria apenas um tipo de dado, teria que ficar copiando código, criar outras classes...
                Poderia então substituir o tipo pelo tipo object, porém, não teria o Type safety, nem Performance, erros
             */

            PrintService<int> printService = new PrintService<int>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);

            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());

        }
    }
}
