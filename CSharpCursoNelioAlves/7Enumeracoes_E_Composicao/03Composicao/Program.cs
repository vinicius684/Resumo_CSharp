using System;
using System.Collections.Generic;
using CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._03Composicao.Entities.Enums;
using System.Globalization;
using CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._03Composicao.Entities;

namespace CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._03Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string Departamento1 = Console.ReadLine();
            Console.WriteLine("=====Enter worker data=====");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level1 = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            Department dept1 = new Department(Departamento1);
            Worker worker1 = new Worker(name1, level1, baseSalary1, dept1);

            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                //HourContract contract = new HourContract(date, valuePerHour, hours);//instanciar o contrato
                worker1.AddContract(new HourContract(date, valuePerHour, hours));//adicionar o contrato ao trabalhador
            }

            Console.WriteLine( );
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker1.Name);
            Console.WriteLine("Department: " + worker1.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker1.Income(year, month));
        }
    }
}
