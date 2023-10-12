using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._3Construtores_This_Sobrecarga_Encapsulamento._5Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               =====Encapsulamento=====
                ->Principio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações 
                segunras e que o mantenham em um estado consistente
                ->Regra de ouro: o objeto sempre deve estar em um estado consistente, e a própria classe deve garantir isso
                ->Ex: um rádio tem exposto apenas operações básicas para utilizar o aparelho de forma segura(não aparece os circuitos etc)

                Implementação manual(encapsulamento clássico)
                *Todo atributo é definido como private
                *impementa-se métodos Get e Set para cada atributo, conforme regrasde negócio
                *Nota: não é usual no C#
             */

            Produto p1 = new Produto("TV", 500.00, 10);

            //p1._nome = Tablet; -> dessa forma definir não funciona mais com o atributo sendo privado
            p1.SetNome("Tablet");

            //Console.WriteLine(p1._nome); -> dessa forma obter não funciona com o atributo sendo privado
            Console.WriteLine(p1.GetNome());
        }
    }
}
