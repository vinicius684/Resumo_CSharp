using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._07HerancaMultipEProblemDiamante.Entities
{
    abstract class Device //Dispositivo
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document); 
    }
}
