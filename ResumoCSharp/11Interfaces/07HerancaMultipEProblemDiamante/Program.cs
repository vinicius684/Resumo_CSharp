using CSharp._11Interfaces._07HerancaMultipEProblemDiamante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._07HerancaMultipEProblemDiamante
{
    internal class program
    {
        static void Main(string[] args) { 
            
            /*
                Em resumo - Uma classe não pode herdar duas classes mas pode implementar mais de uma interface
            */

            Printer p = new Printer() { SerialNumber = 1080};
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2030 };
            p.ProcessDoc("My letter");
            p.Print(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921};
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
