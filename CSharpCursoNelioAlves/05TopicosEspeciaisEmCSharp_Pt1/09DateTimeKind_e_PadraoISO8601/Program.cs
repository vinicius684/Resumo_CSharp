using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._5TopicosEspeciaisEmCSharp_Pt1.DateTimeKind_e_PadraoISO8601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====DateTimeKind=====
                    ->Tipo enumero especial que define três valores possíveis para a localidade da data:
                        *Local - fuso horário do sistema
                        *Utc - horário em greenwich
                        *Unspecified
                    
                    ->Boa prática: 
                        *Armazenar em formato UTC(texto: BD / Json / XML)
                        *Instanciar e mostrar em formato local
                    '->Para converter um DateTime para Local ou Utc, deve usar:
                        *myDate.ToLocalTime()
                        *myDate.ToUniversalTime()
             */

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);//instanciando a data no horário local

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);//instaciando a data no horário utc

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            Console.WriteLine("\n-----------------\n");

            /*
             =====Padrão ISO 8601=====
                ->Formato: yyyy-MM-ddTHH:mm:ssZ   (T é por definição e z significa Utc)
             */
            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");//Data armazenada no fromato utc, porém vai ser instanciada no formato local

            //1 - erro, como kind não foi especificado vai tanto subtrair no local quanto aumentar no utc
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4 kind: " + d4.Kind);
            Console.WriteLine("d4 to Local: " + d4.ToLocalTime());
            Console.WriteLine("d4 to Utc: " + d4.ToUniversalTime());
            Console.WriteLine();
            //2 - forma correta de se fazer
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5 kind: " + d5.Kind);
            Console.WriteLine("d5 to Local: " + d5.ToLocalTime());
            Console.WriteLine("d5 to Utc: " + d5.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d4.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d4.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
