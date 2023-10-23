using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._1LogicaProgCSharp
{
    internal class _13ExEstrCondicional
    {
        static void Main(string[] args)
        {
            /*IMPORTANTE 4 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
            int horaInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao = 0;
            if (horaInicial < horaFinal)
            {
                duracao = horaInicial - horaFinal; duracao = 24 - horaInicial + horaFinal;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O jogo dureou" + duracao + "horas");

            /*5 -Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            seguir, calcule e mostre o valor da conta a pagar.*/
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            double quantidade = double.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            /*IMPORTANTE 6 -Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. */
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            /* IMPORTANTE 8 -Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
            salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
            de 8% sobre R$ 1000.00 */

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;

            if (salario <= 2000)
            {
                imposto = 0;
            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento de imposto");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
