using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._7ExMembrosEstaticos
{
    internal class ConversorMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100;
        }
    }
}
