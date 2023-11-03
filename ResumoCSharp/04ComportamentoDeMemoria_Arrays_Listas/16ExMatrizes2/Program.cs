using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._16ExMatrizes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as quantidade de linhas: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as quantidade de colunas: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)//Percorrer as linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)//Percorrendo as colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite o número da matriz cujo a partir de cada ocorrencia você quer ver os valores a esquerda, cima, direita e baixo");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == x)
                    {
                        //Console.WriteLine("Esquerda: " + mat[i, j - 1] + "; Cima: " + mat[i - 1, j] + "; Direita: " + mat[i, j + 1] + "; Baixo" + mat[i + 1, j]);
                        Console.WriteLine("Posição: " + i + ", " + j);
                        if ((j - 1) >= 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        else { }
                        if ((i - 1) >= 0)
                        {
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        }
                        else { }
                        if ((j + 1) < m)
                        {
                            Console.WriteLine("Direita; " + mat[i, j + 1]);
                        }
                        else { }
                        if ((i + 1) < n)
                        {
                            Console.WriteLine("Baixo: " + mat[i + 1, j]);
                        }
                    }
                    else { }
                }
            }

        }
    }
}
