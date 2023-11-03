using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7Enumeracoes_E_Composicao._04Exercicio_StringBuilder.Entities;

namespace CSharp._7Enumeracoes_E_Composicao._04Exercicio_StringBuilder.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment(string text) { 
            Text = text;
        }

    }
}
