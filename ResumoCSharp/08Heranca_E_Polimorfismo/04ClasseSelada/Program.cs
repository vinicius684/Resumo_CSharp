using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8Heranca_E_Polimorfismo.Classe_Selada;

namespace CSharp._8Heranca_E_Polimorfismo._04ClasseSelada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ========Classes e métodos selados==========
                    -Palavra Chave: sealed

                    -Classe: evita que a classe seja herdada
                        *Nota:ainda é possivel extender a funcionalidade de uma classe selada usando "extension methods(sera aprendido mais pra frente no curso)"
                          namespace Course{
                            sealed class SavingAccount{
                                //colocar sealed na frente da classe, ela não poderá ser herdada

                    -Método:evita que um método sobreposto possa ser sobreposto novamente
                        *Só pode ser aplicado a métodos sobrepostos
                
             */

            /*
                -Segurança, 
                *regra de negócio, 
                *geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem ser uma porta de 
                 entrada para inconsistências
                
                -Performance
                *atributos de tipo de uma classe selada são analisados de forma mais rápida em tempo de execução 
                
                
             */
        }
    }
}
