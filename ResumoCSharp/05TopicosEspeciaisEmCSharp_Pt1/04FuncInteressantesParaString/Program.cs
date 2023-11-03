using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._5TopicosEspeciaisEmCSharp_Pt1._04FuncInteressantesParaString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             outras operações como: Conversão str para número; ou Conversão número para str - no png
             */

            string original = "abcd FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();//tudo em maiúsculo
            string s2 = original.ToLower();//tudoem minusculo
            string s3 = original.Trim();//apaga os espaços em branco

            int n1 = original.IndexOf("bc");//indice da primeira ocorrência
            int n2 = original.LastIndexOf("bc");//indice da última ocorrência

            string s4 = original.Substring(3);//pega a string a partir do indice 3
            string s5 = original.Substring(3, 5);//pega a string a partir do indice 3 até o indice 5

            string s6 = original.Replace('a', 'x');//trocar todo caractere 'a' por 'x'
            string s7 = original.Replace("abc", "xy");//troca toda string por outra string

            bool b1 = String.IsNullOrEmpty(original);//retorna um bool se a string está é null or empty
            bool b2 = String.IsNullOrWhiteSpace(original);//retorna um bool se a string é null or whitespace

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "+");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace(\"abc\", \"xy\"): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}
