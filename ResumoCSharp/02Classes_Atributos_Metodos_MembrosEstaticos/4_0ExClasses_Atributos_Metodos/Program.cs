using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._4_0ExClasses_Atributos_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1;

            F1 = new Funcionario();

            F1.Nome = Console.ReadLine();
            F1.SalarioBruto = double.Parse(Console.ReadLine());
            F1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(F1);

            double porcent = double.Parse(Console.ReadLine());
            F1.AumentarSalário(porcent);

            Console.WriteLine(F1);
        }
    }
}
