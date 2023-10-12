using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._5TopicosEspeciaisEmCSharp_Pt1._6TimeSpan_RepresentandoDuracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              =====TimeSpan=====
                ->Representa uma DURAÇÂO
                ->É um tipo valor(struct)

                '->Um objeto TimeSpan internamente armazena uma duração na forma de ticks(100 nanosegundos)
             */

            TimeSpan t1 = new TimeSpan(0, 1, 30);//hh:mm:ss
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine("------");

            //Instanciação
            //Construtores
            TimeSpan t2 = new TimeSpan();//zerado
            TimeSpan t3 = new TimeSpan(900000000L);//timespan a partir de ticks 00:01:30
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);//dd.hh:mm:ss
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);//dd.hh:mm:ss.milissegundos

            //Builders
            TimeSpan t7 = TimeSpan.FromDays(1.5);//1 dia e meio (1.12:00:00)
            TimeSpan t8 = TimeSpan.FromHours(1.5);//1 hora e meia
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine("--------");
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);

        }
    }
}
