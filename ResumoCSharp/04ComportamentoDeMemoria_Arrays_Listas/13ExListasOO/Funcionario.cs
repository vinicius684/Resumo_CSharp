using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._13ExListasOO
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void PorcentAumentoSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
