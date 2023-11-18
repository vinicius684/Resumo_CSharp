using CSharp._12Generics_Set_Dictionary._06Exercicio.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CSharp._12Generics_Set_Dictionary._09ExercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine(); //C:\Users\vpinh\OneDrive\Área de Trabalho\CSharpCursoNelioAlves\ResumoCSharp\12Generics_Set_Dictionary\09ExercicioDictionary\FileVotacao.txt
          
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> votacao = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(',');
                        string nome = vect[0];
                        int votos = int.Parse(vect[1]);

                        if (votacao.ContainsKey(nome)){
                            votacao[nome] = votacao[nome] + votos;
                        }
                        else
                        {
                            votacao[nome] = votos;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in votacao)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
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
