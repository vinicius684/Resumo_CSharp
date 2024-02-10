using System.Linq;

namespace CSharp._14ExpressoesLambda_Delegates_LINQ._08LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               =====LINQ - Language Integrated Query=====
                -É um conjunto de tecnologias baseadas na integração de funcionalizades de consulta diretamente na 
                linguagem C#
                     -Operações chamadas diretamente a partir das coleções
                     -Consultas são objetos de primeira classe
                     -Suporte de compilador e IntelliSense da IDE
                
                -Namespace:System.Linq

                -Possui diversas operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões de sintaxe 
                similar à SQL
             */

            /*
             Para trabalhar com LINQ, são 3 passos:
                -Criar um data source (coleção, array, recurso de entrada ou saida, etc)
                -Definir a query
                -Executar a query (foreach ou alguma operação terminal(operação que vai forçar essa consulta ser executada)) - Execussão terdia
                
                DataSource -> Query ->Execution
             */

            //1-Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //2-Define the query expression - Demo: Pegar todo numeo que for par e multiplica-lo por 10, gerando uma nova coleção

            //Where - filtra minha fonte de dados
            //Expressão do Where - Todo numero x tal que x % 2 é igual a 
            //Select - para aplicar um função em cada elemento da coleção original, gerando assim uma nova função
            //Recebe um número x e devolve o x multiplicado por 10
            var result = numbers.Where(x => x% 2 == 0).Select(x => x * 10); 
            //IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Execute the query
            foreach (int x in result) {
                Console.WriteLine(x);
            }


        }
    }
}
