using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._07HerancaMultipEProblemDiamante.Entities
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document) //não está mais herdando, sim cumprindo contrato
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document) 
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
