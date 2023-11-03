using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._2ProblemaComOO_Atrib_Metodos
{
    internal class Triangulo
    {
        public double A;//declarando atributos
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
