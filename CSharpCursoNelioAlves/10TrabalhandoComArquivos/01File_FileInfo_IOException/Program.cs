using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp._10File_FileInfo_IOException
{
    internal class Program
    {
        public static void Main()
        {
            /*
             * =====File e FileInfo===== 
                -Duas classes básicas para utilização de arquivos que pertencem ao Namespace System.IO
                -Realizam Operações com arquivos(create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream.

                -File 
                    - static members(simples, mas realiza a verificação de segurança para cada operação) - link documentação

                - FileInfo
                    - instance members - link documentação

                - IOException - Superclasse de todas as exceções possiveis que podem acontecer ao trabalhar com arquivos
             */

            string sourceParth = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File1.txt";
            string targetPath = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File2.txt";

            //as duas classes tem várias outras funções
            try
            {
                FileInfo fileInfo = new FileInfo(sourceParth);//instanciando classe/Objeto para trabalhar com arquivos
                //fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourceParth);//vetor de string recebe
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch(IOException e) {
                Console.Write("An error occurred: ");
                Console.WriteLine(e.Message);
            }
                
        }
    }
}
