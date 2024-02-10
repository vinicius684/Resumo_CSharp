using CSharp._14ExpressoesLambda_Delegates_LINQ._04MultiDelegates.Service;

namespace CSharp._14ExpressoesLambda_Delegates_LINQ._04MultiDelegates
{

    delegate void BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            =====Muti delegates=====
            -Delegates que guardam a referência para mais de um método
            -Para adicionar uma referência, pode-se usar o operador +=
            -A chamada Invoke(ou sintaxe reduzida) executa todos os métodos na ordem em que foram adicionados
            -Seu uso faz sentido para métodos void
         */


            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax; 

            op.Invoke(a, b);

        }
    }
}
 
