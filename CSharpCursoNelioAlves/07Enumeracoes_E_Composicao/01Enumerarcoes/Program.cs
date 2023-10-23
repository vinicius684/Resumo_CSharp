using CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._01Enumerarcoes.Entities;
using CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._01Enumerarcoes.Entities.Enuns;

namespace CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._01Enumerarcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Enumerações vai dar a base para criar ciclo de vida de entidade
                Ex: Pedido, vai ter os estados do pedido, isso pode ser representado por uma enumeração
               Composição de objetos
                Ex: Pedido que tem os ItensPedido, Cada ItensPedido tem um Produto, Pedido tem cliente...       
             */

            /*
             Enumerações - Tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
                Palavra chave em C#: enum (é um tipo valor)
                Vantegem: melhor semântica, código mais legível e auxiliado pelo compilador
                Ex: Ciclo de vida de um pedido: PagamentoPendente -> Processando -> Enviado -> Entregue
             */

            Order order1 = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Pendingpayment
            };

            Console.WriteLine(order1);

            //Conversão de enum para string e vice-versa
            string statusorder1 = order1.Status.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>(statusorder1);

            Console.WriteLine(statusorder1);
            Console.WriteLine(os);
        }
    }
}
