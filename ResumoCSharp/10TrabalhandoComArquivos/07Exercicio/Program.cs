using System.Globalization;
using CSharp._10TrabalhandoComArquivos.Exercicio.Entities;
using System.IO;

namespace CSharp._10TrabalhandoComArquivos.Exercicio
{
    internal class Program
    {
        public static void Main()
        {
            //arquivo de origem dos dados
            string path = @"C:\Users\vpinh\OneDrive\Área de Trabalho\File1.txt";          

            try
            {
                /*
                    Ler o caminho de um arquivo .csv contendo os dados de itens vendidos. Cada item possui um nome, preco e quantidade
                    separados por virgula. Voce deve gerar um anovo arquivo chamado "summary.csv", localizado em uma subpasta chamada "out"
                    a partir da pasta original do arquivo de origem, contendo apenas o nome e o valor total para aquele item.
                 */
                /*Nélio não usou lista*/

                string[] lines = File.ReadAllLines(path);

                List<DocEntrada> list = new List<DocEntrada>();

                Directory.CreateDirectory(@"C:\Users\vpinh\OneDrive\Área de Trabalho\outTEste");//criação de uma pasta
                string targetPath = @"C:\Users\vpinh\OneDrive\Área de Trabalho\outTEste\summary.txt";//criação de um arquivo dentro da pasta criada

                using (StreamWriter sw = File.AppendText(targetPath))//AppendText acrescentar ao final do arquivo
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] aux = lines[i].Split(',');
                        string nome = aux[0];
                        double preco = double.Parse(aux[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(aux[2]);
                        list.Add(new DocEntrada(nome, preco, qtd));
                        sw.WriteLine(list[i].Nome + "," + list[i].Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(ex.Message);
            }           


        }

    }
}
