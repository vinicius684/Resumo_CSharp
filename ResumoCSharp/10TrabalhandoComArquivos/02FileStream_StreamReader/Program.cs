using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp._10TrabalhandoComArquivos._02FileStream_StreamReader
{
    internal class Program
    {
        public static void Main()
        {
            /*
              =====FileStreams=====stream binária
                -É uma classe que disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita
                -Suporte a dados binários

                doc - FileStream - read byter ou write bytes

                Instanciação:
                    -Varios construtores
                    -File/FileInfo

              =====StreamReader=====stream de caracteres
                -É um stream capaz de ler caracteres a partir de uma stream binária(ex: FileStream)
                -Suporte a dados no formato texto

                doc - FileStream - StreamReader - read chars
            
                Instanciação:
                        -Varios construtores
                        -File/FileInfo

             ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== =====
             */


            /*
            string parth = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(parth, FileMode.Open);//caminho e ação
                sr = new StreamReader(fs);
                string line = sr.ReadLine(); ;
                Console.WriteLine(line);

            }
            catch (IOException ex)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(ex.Message);
            }
            finally { 
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
               /*OBS:FileStream e StreamReader são recursos externos, estão conversando diretamente com o sistema operacional,
                logo não é gerenciado pelo crl do .NET, então precisa-se fechar o recurso manualmente
            }
             ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== ===== =====
             */


            /*intanciar duas classes para trab coma arquivo é uma forma moderna de se trabalhar e etc, porem desconfortável,
             para isso pode-se usar o OpenText implicitamente instancia um FIleStream               
             */

            string path = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File1.txt";
        
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);//OpenText implicitamente já instancia o FileStream e instancia o sr encima dele
                while (!sr.EndOfStream) { //ler arquivo inteiro
                    string line = sr.ReadLine(); 
                    Console.WriteLine(line);
                }
                //string line = sr.ReadLine(); ler apenas primeira linha
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                /*OBS:FileStream e StreamReader são recursos externos, estão conversando diretamente com o sistema operacional,
                 logo não é gerenciado pelo crl do .NET, então precisa-se fechar o recurso manualmente*/
            }


        }
    }
}
