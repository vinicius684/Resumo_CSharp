using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._6CalcFuncaoEstaticaDeInstancia
{
    class Calculadora
    {
        //não tem membros de Instanciação, apeans estáticos
        public double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
