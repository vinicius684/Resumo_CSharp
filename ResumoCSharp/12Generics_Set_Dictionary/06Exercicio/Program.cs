using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._12Generics_Set_Dictionary._06Exercicio.Entities;

namespace CSharp._12Generics_Set_Dictionary._06Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine(); //C:\Users\vpinh\OneDrive\Área de Trabalho\CSharpCursoNelioAlves\ResumoCSharp\12Generics_Set_Dictionary\06Exercicio\InputFile.txt
            HashSet<Log> set = new HashSet<Log>();
            int aux = 0;
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        set.Add(new Log(sr.ReadLine()));
                    }                  
                }
                Console.WriteLine("Total users: "+set.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
