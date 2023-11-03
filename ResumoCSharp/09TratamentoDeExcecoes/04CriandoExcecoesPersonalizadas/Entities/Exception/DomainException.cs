using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._09TratamentoDeExcecoes._04CriandoExcecoesPersonalizadas.Entities.Exception
{
    internal class DomainException : ApplicationException //herdar de application exception (Exception personalizada)
    {
        public DomainException(string messege) : base(messege) { 
        
        }
    }
}
