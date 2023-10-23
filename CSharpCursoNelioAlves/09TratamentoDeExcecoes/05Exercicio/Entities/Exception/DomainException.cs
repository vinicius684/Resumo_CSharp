using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._09TratamentoDeExcecoes._05Exercicio.Entities.Exception
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string messege) : base(messege)
        {

        }
    }
}
