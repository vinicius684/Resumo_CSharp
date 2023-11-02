using System.IO;
using System.Collections.Generic;

namespace CSharp._10TrabalhandoComArquivos._05Directory_DirectoryInfo
{
    internal class Program
    {
        public static void Main()
        {
            /*
             =====Directory(static members), DirectoryInfo(instance members)===== Links dmentação
               -Namespaces System.IO
               -Operações com pastas(create, enumerate, get files, etc)
               -mesma linha do File e FileInfo
             */

            string path = @"C:\Users\vpinh\OneDrive\Área de Trabalho\Directore1";

            try
            {
                //IEnumerable - tipo mais genérico de Collection
                //var folders = .... tb funcionaria

                //listar pastas
                IEnumerable<string> folder = Directory.EnumerateDirectories(path,"*.*", SearchOption.AllDirectories);//caminho, padrão de busca("*.*"qualquer arquivo e qualquer extensão), Opção de busca
                Console.WriteLine("Folders:  ");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }

                //listas arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);//caminho, padrão de busca("*.*"qualquer arquivo e qualquer extensão), Opção de busca
                Console.WriteLine("Files:  ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                //criar uma pasta
                Directory.CreateDirectory(@"C:\Users\vpinh\OneDrive\Área de Trabalho\newfolder");
            }
            catch (IOException e)
            {
                Console.Write("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
