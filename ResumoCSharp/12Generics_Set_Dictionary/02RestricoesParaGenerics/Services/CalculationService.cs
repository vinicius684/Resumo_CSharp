using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._12Generics_Set_Dictionary._02RestricoesParaGenerics.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable { //a minha lista tem que ser de um tipo qualquer desde que seja de um tipo ICamparable
            if (list.Count == 0) {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) { //comparando valores de um tipo generico
                    max = list[i];
                }
            }
            return max;

        }
    }
}
