using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._4ComportamentoDeMemoria_Arrays_Listas._06ExVetores
{
    internal class AluguelQuartosAlunos
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public AluguelQuartosAlunos(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
