using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._4ComportamentoDeMemoria_Arrays_Listas._14Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             =====Matrizes======
                ->Arranjos bidimensionais
                  *Homogênea(dados do mesmo tipo)
                  *Ordenada(elementos acessados por meio de posições)
                  *Alocado de uma vez só
                  
                ->Vantagens: Acesso imediato aos elementos pela sua posição
                ->Desvantagens: Tamanho fixo; Dificuldade para se realizar inserções/deleções(não tem o "nó" tudo tem que ser movido)
             */

            double[,] mat = new double[2, 3];//linhas, colunas 

            Console.WriteLine(mat.Length);//tamanho/quantidade de espaços de memória 6

            Console.WriteLine(mat.Rank);//quanto é a primeira dimensão da matriz/linhas

            Console.WriteLine(mat.GetLength(0));//tamanho da 1 dimensão da matriz/linhas

            Console.WriteLine(mat.GetLength(1));//tamanho da segunda dimensão da matriz/colunas



        }
    }
}
