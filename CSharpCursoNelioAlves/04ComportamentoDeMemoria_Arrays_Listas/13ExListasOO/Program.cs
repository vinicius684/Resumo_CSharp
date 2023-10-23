using CSharpCursoNelioAlves._2Classes_Atributos_Metodos_MembrosEstaticos._4_0ExClasses_Atributos_Metodos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._4ComportamentoDeMemoria_Arrays_Listas._13ExListasOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Quantos funcionários serão registrados?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Id do funcionário que o salário será aumentado: ");
            int id_aux = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == id_aux);//func passa a ser o item cujo Id é igual a id_aux 

            if (func != null)
            {
                Console.Write("Porcentagem a ser aumentada: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.PorcentAumentoSalario(porcent);
            }
            else
            {
                Console.WriteLine("Esse id não existe");
            }

            Console.WriteLine("\nFuncionárrio atualizados: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
