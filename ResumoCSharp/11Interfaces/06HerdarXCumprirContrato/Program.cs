using CSharp._11Interfaces._06HerdarXCumprirContrato.Entities;
using CSharp._11Interfaces._06HerdarXCumprirContrato.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._06HerdarXCumprirContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IShape s1 = new Circle(Color.Black, 2.0);
            IShape s2 = new Rectangle_(Color.Blue, 3.5, 4.2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
