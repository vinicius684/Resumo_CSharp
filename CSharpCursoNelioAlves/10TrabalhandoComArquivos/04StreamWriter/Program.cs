using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._10TrabalhandoComArquivos._04StreamWriter
{
    internal class Program
    {
        public static void Main()
        {
            /*
                =====StreamWriter=====
                 -Stram capaz de escrever caracteres a partir de uma stream binária(ex: FileStream)
                 
                 -Suporte adados no formato texto

                    doc - FileStram - StreamWriter - Write chars    

                 -Instantiation
                    -Several constructors
                    -File/FileInfo
                        -CreateText(path)
                        -AppendText(string)
             */

            string sourceParth = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File1.txt";
            string targetPath = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourceParth);
                using (StreamWriter sw = File.AppendText(targetPath))//AppendText acrescentar ao final do arquivo
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.Write("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
