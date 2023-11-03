using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._4_1ExClasses_Atributos_Metodos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            a1.Nome = Console.ReadLine();
            a1.Nota1 = double.Parse(Console.ReadLine());
            a1.Nota2 = double.Parse(Console.ReadLine());
            a1.Nota3 = double.Parse(Console.ReadLine());

            double final1 = a1.NotaFinal();

            if (a1.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam " + a1.PontosFaltantes());
            }
        }
    }
}
