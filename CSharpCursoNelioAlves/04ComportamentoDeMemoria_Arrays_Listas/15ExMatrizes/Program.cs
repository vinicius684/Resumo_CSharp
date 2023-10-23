using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._4ComportamentoDeMemoria_Arrays_Listas._15ExMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros. Em seguida, mostrar
             a diagonal principal e a quantidade de valores negativos da matriz  
            */

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)//Percorrer as linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)//Percorrendo as colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count += 1;
                    }
                    else { }
                }
            }
            Console.WriteLine("Amount of negative numbers: " + count);

        }
    }
}
