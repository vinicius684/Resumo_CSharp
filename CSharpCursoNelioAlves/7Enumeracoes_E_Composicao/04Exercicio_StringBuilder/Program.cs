using CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._03Composicao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._04Exercicio_StringBuilder.Entities;


namespace CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._04Exercicio_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do terminal
                '->como obter os itens da lista do tipo objeto filho
             */

            Post Post1 = new Post(
                DateTime.Parse("2000-08-15 13:05:58"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            Post1.AddComment(new Comment("Have a nice trip"));
            Post1.AddComment(new Comment("Wow Thats awesome!"));

            Post Post2 = new Post(
               DateTime.Parse("2000-08-15 13:05:58"),
               "Good night guys",
               "See you tomowrow",
               5
               );
            Post2.AddComment(new Comment("Good Night"));
            Post2.AddComment(new Comment("May the Force be sith you"));

            Console.WriteLine(Post1);
            Console.WriteLine(Post2);

        }


    }
}

