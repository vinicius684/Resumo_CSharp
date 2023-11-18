using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._11Interfaces._08InterfaceIComparable.Entities;

namespace CSharp._11Interfaces._08InterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Essa interface é um padrão utilizado pela linguagem para se comparar um objeto com outro
                Compara - dizer se é maior, menor ou igual ao outro

                tenho que implementa-la para utilizar por exemplo o list.Sort(); // Ordenação

                Bastante abstração, para implementar o CompareTo da classe é necessário utilizar CompareTo dos tipos primitivos em algum momento
                e depois esse CompareTo da classe vai ser usado implicitamente no list.Sort()
             */

            string path = @"C:\Users\vpinh\OneDrive\Área de Trabalho\CSharpCursoNelioAlves\ResumoCSharp\11Interfaces\08InterfaceIComparable\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();//Ordenar lista / Faz o uso da Interface IComparable
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
