using CSharpCursoNelioAlves._8Heranca_E_Polimorfismo.IntroducaoPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._05IntroducaoPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args) {
            /*
               ========Polimorfismo========
                -É recurso que permite que variáveis de um mesmo tipo mais genérico posssam apontar para objetos de tipos 
                específicos diferentes, tendo assim comportamentos diferntes conforme cada tipo específico.
                   *Upcasting é um Polimorfismo(tranquilo, porém o polimorfismo pode desdobrar em várias coisas interessantes e complexas)
                   *A associação do tipo específico com tipo genérico é feita em tempo de execução(Upcasting)   
                    '->O compilador não sabe para qual tipo específico a chamada do método Withdraw está sendo feita (só sabe que são duas variáveis tipo Account)
             */

            /*Exercício Resolvido*/

            List<Employee> listEmployee = new List<Employee>();
            Console.Write("Enter the number of emplyees: ");
            int nEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < nEmployees; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)?");                
                char outSouced_Y_N = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine());

                if (outSouced_Y_N == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    listEmployee.Add(new OutsourceEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    listEmployee.Add(new Employee(name, hours, valuePerHours));
                }

                Console.WriteLine();

            }
            Console.WriteLine("Payments: ");
            foreach (Employee obj in listEmployee)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
