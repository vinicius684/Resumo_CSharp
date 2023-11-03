using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._01TipoReferenciaVsTipoValor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 -Classes são tipo referência(ponteiros) 
                    *Um espaço de memória(no stack) que aponta para outro espaço de memória(no heap), onde estão os atributos
                 
                 -Structs são tipo valor(tipos básicos, DateTime e TimeSpan)
                    *Espaçõs de memória que recebem diratamente um valor(no stack)
                    *É possível criar meu próprio struct Ex: Struct ponto x e y      
             */


            Point p3;
            //Console.WriteLine(p3);Erro valores não atribuidos

            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            Point p2 = new Point();//new - cria com os valores padrão (Ex: int = 0)
            Console.WriteLine(p2);
        }
    }
}
