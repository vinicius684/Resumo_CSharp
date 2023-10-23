using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._4ComportamentoDeMemoria_Arrays_Listas._04Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              =====Vetores=====
                ->Arranjo unidimensional
                    *Homogêneo(dados do mesmo tipo)
                    *Ordenado(elementos acessados por meio de posições)
                    *Alocado de uma só vez só, em um bloco contíguo de memória
                ->Vantagens: acesso imediato aos elementos pela sua posição
                ->Desvantagens: tamanho fixo; dificuldade para se realizar inserções e deleções
             */
            //Vetores tipo Struct
            //como iniciar o vetor com valores double[] vect = new double[] { 1, 2, 9 };

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;

            Console.WriteLine("Altura média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
