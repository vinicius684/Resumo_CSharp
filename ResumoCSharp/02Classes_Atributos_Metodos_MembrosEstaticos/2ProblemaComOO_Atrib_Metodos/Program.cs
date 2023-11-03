using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2Classes_Atributos_Metodos_MembrosEstaticos._2ProblemaComOO_Atrib_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Classe - Tipo estruturado que pode conter(membros) da Entidade ou Serviço ou Utilitários etc:
                -> Atributos (dados/campos)
                -> Método (função/operadores)
                
            obs: tb pode prover muitos outros recursos, como: construtores, sobrecarga, encapsulamentoo, henraça, polimorfismo     
             */

            Triangulo x, y;//declarando as variáveis do tipo Tringulo

            x = new Triangulo();//instanciando as variáveis(x aponta para o obj composto contendo a b c )
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Acessando os atributos
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre coma as medidas do tringulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();//"chamando" o método

            double areay = y.Area();

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
