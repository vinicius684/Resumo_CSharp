using System;
using System.Globalization;

namespace CSharp._1LogicaProgCSharp
{
    class SaidaDeDadosCSharp
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.3456;
            string nome = "Maria";

            Console.Write("Bom Dia");//não pula linha
            Console.WriteLine("Hello, World!");//pula linha

            Console.WriteLine("-------------------");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));//delimitar o número de casas decimais, arredondando
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));// '.' ao inves de ',', necessário incuir biblioteca

            Console.WriteLine("-------------------");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais ", nome, idade, saldo);//Placeholders
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");//Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");//Concatenação(unico possivel de usar o CultureInfo)

        }
    }
}
