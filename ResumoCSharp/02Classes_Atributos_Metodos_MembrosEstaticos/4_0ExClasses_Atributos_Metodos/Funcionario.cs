using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._4_0ExClasses_Atributos_Metodos
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalário(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
