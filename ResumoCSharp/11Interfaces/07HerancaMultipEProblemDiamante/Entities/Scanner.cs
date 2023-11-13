using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._07HerancaMultipEProblemDiamante.Entities
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document) //não está mais herdando, sim cumprindo contrato
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan() {
            return "Scanner scan result";
        }
    }
}
