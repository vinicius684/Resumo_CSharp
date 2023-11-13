using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._6CalcFuncaoEstaticaDeInstancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             =====Membros Estáticos=====
                 ->Tb chamados de membros de classe. Em oposição a membros de instância
                 ->Fazem sentido independentemente de objetos. São chamados a partir do próprio nome da classe
                 ->Aplicações comuns: Classes utilitárias e Declaração de constantes(Ex: Math.qrt() )
                 ->Uma classe com apenas membros estáticos, é uma classe estática. E não pode ser instanciada

                Em resumo: Apenas Atributos Constantes  e Metodos que fazem sentido sem atributos variáveis        

             */

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine(circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferencia: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
