using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento._9ExContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Tudo Ok, porém Nélio pensou a logica um pouco diferente: -> Imagem
                ->Se haveraDeposito = 's', recebe um construtor de 3 argumentos com Saldo = Deposito inicial, Senão recebe um contrutor de 2 argumentos e saldo 0.0

                ->Minha lógica = Instancio fora com contrutor de 2 argumentos, se haveraDeposito = 's', chamo o método de depósito e o saldo passa a ser o deposito inicial, senão saldo continua como 0
             */

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o títular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá Depósito inicial?(s/n): ");
            char haveraDeposito = char.Parse(Console.ReadLine());

            ContaBancaria c1 = new ContaBancaria(numero, titular);

            if (haveraDeposito == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1.Depósito(depositoInicial);
            }
            else
            {

            }

            Console.WriteLine("\nDados da Conta: \n" + c1);

            Console.Write("\nEntre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            c1.Depósito(quantia);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c1 + "\n");

            Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            c1.Saque(quantia);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c1);

        }
    }
}
