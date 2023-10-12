using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._2Classes_Atributos_Metodos_MembrosEstaticos
{
    class _5CalcFuncaoEstaticaNaMain
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferencia: " + vol.ToString("F2", CultureInfo.InvariantCulture));

        }
        static double Circunferencia(double r)//Pi é estático, logo a função que vai recebe-lo deve ser estática tbm
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
