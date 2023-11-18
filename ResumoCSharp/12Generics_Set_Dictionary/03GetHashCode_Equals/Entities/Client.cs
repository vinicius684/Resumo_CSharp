using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._12Generics_Set_Dictionary._03GetHashCode_Equals.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)//sobrescrevendo metodos
        {
            if (!(obj is Client))  
            { 
                return false; 
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()//sobrescrevendo metodos
        {
            return Email.GetHashCode();
        }

    }
}
