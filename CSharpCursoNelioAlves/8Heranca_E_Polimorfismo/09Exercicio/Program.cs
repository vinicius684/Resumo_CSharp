using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities;
using CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._09Exercicio.Entities;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._09Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();

            Console.Write("Enter the number of pax payers: ");
            int nTaxpayer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nTaxpayer; i++)
            {
                Console.WriteLine("Taxpayer #" + i + " data:");
                Console.Write("Individual or company (i/c)?");
                char i_c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if (i_c == 'i')
                {
                    Console.Write("Health Income: ");
                    double healthIncome = double.Parse(Console.ReadLine());                   
                    list.Add(new IndividualTaxpayer(name, annualIncome, healthIncome));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());
                    list.Add(new CompanyTaxpayer(name, annualIncome, nEmployees));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nTaxes Paid");
            foreach (Taxpayer taxpayer in list)
            {
                Console.WriteLine(taxpayer.Name + ": $" + taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("\nTotal Taxes");
            double sum = 0;
            foreach (Taxpayer taxpayer in list)
            {
                sum= sum + taxpayer.Tax();
            }
            Console.WriteLine(sum);

        }
    }
}
