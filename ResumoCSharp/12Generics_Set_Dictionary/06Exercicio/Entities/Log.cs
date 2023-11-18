using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp._12Generics_Set_Dictionary._06Exercicio.Entities
{
    internal class Log
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public Log(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(' ');
            UserName = vect[0];
            Instant = DateTime.Parse(vect[1]+"Z");
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();// + Instant.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Log))
            {
                return false;
            }
            Log other = obj as Log;
            return UserName.Equals(other.UserName); //&& Instant.Equals(other.Instant);
        }

        public override string ToString()
        {
            return UserName + ", " + Instant;
        }


    }
}
