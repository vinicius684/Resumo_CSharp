using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCursoNelioAlves._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birtTime) { 
            Name = name;
            Email = email;
            BirthDate = birtTime;
        }
    }
}
