using CSharp._14ExpressoesLambda_Delegates_LINQ._03IntroducaoDelegates.Services;

namespace CSharp._14ExpressoesLambda_Delegates_LINQ._03IntroducaoDelegates
{
    //Declaração do meu delegate. Está especificando que vai ser um referência para uma função que recebe dois double e retorna um double
    delegate double BinaryNumericOperation(double n1, double n2); 

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====Delegates=====
                -É uma referência (como Type safety) para um ou mais métodos
                    -É um tipo referência

                -Usos comuns:
                    -Comunicação entre objetos de forma flexível e extensível(eventos / Callbacks)
                    -Parametrização de operadores por métodos(programação funcional)

                -Delegates pré-definidos
                    -Action
                    -Func
                    -Predicate
             */

            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            BinaryNumericOperation op = CalculationService.Sum;

            double result = op.Invoke(a, b);
            Console.WriteLine(result);

        }
    }
}
