using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._2Classes_Atributos_Metodos_MembrosEstaticos._7ExMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            double qtd = double.Parse(Console.ReadLine());

            double resultado = ConversorMoeda.DolarParaReal(qtd, cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
