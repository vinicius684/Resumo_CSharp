using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._10TrabalhandoComArquivos._03BlocoUsing
{
    internal class Program
    {
        public static void Main()
        {
            /*
              =====Using Block =====
                -Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
                
                -Objetos IDisposable não são gerenciados pelo CLR. Eles precisam ser manualmente fechados.
                    Ex: Font,FileStream, StreamReader, StreamWriter
             */

            string path = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File1.txt";

            try
            {
                //using (StreamReader sr = File.OpenText(path)) { }//simplificado
                using (FileStream fs = new FileStream(path, FileMode.Open)) //tudo nesse bloco será realizado e ao final o recurso instanciado será automaticamente fechado
                { 
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        { //ler arquivo inteiro
                            string line = sr.ReadLine(); ;
                            Console.WriteLine(line);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
