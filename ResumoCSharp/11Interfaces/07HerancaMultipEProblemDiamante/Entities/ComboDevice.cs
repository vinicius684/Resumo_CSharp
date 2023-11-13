using System;

namespace CSharp._11Interfaces._07HerancaMultipEProblemDiamante.Entities
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            throw new NotImplementedException();
        }
    }
}
