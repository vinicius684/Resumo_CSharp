using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos
{
    class _1ProblemaSemOO_AreaTriagulo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            double xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre coma as medidas do tringulo Y: ");
            double ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double px = (xa + xb + xc) / 2;

            double py = (ya + yb + yc) / 2;

            double areax = Math.Sqrt(px * (px - xa) * (px - xb) * (px - xc));

            double areay = Math.Sqrt(py * (py - ya) * (py - yb) * (py - yc));

            Console.WriteLine("Area de X = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
