using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._5TopicosEspeciaisEmCSharp_Pt1
{
    class _1PalavraVar
    {
        static void Main(string[] args)
        {
            /*
             Inferência de dados: palavra var
             obs:tipagem é benefico, manutenção, segurança, porém existe a palavra var, para caso tenha a necessidade de usar
             */

            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
