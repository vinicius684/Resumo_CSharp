using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._5TopicosEspeciaisEmCSharp_Pt1._5DateTime_RepresentandoDataEHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             =====DateTime=====
                ->Representa um INSTANTE
                ->É um tipo valor (struct)

                '->Representação Interna:
                   *Um objeto DateTime internamente armazena o número de "ticks"(100 nanosegundos) desde a meia noite do dia 1 de 
                    janeiro do ano 1 da era comum
             */

            DateTime d1 = DateTime.Now;//date time atual
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine("-------");

            //Instanciação
            //Construtores mais utilizados
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            //Builders mais utilizados
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;//horário de agora no horário universal(no greewich)

            DateTime d8 = DateTime.Parse("2000-08-15");//string para DateTime
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);//entrar da forma que eu quiser e ele será instanciado corretamente
            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d12);
            Console.WriteLine(d13);
        }
    }
}
