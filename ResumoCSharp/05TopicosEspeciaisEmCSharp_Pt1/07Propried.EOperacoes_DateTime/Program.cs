using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._5TopicosEspeciaisEmCSharp_Pt1._7Propried.EOperacoes_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine(d);

            //Propriedades
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);//local ou universal
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("------------");

            //Formatações
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("------------");

            //Operações
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            DateTime d4 = d.AddDays(4);//bem útil para calcular data de vencimento do boleto, por exemplo

            DateTime d_ = new DateTime(2001, 10, 18);
            TimeSpan d5 = d_.Subtract(d);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
        }
    }
}
