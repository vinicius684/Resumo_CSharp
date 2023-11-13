using System.Globalization;
using System;
using System.Data;

namespace CSharp._11Interfaces._08InterfaceIComparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString() { 
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj) //recebe outro funcionario - Implicito como faz isso(logica tá no sort)
        {
            if (!(obj is Employee)) {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee; //recebe obj se for Employee
            return Salary.CompareTo(other.Salary); //CompareTo da classe double - Funcionario atual Comparado a outro (?)
        }
    }
}
