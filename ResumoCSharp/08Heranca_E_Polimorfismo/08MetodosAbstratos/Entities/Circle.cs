using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities.Enums;

namespace CSharp._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(Color color, double radius) : base(color)
        { 
            Radius = radius;
        }

        public override double Area() { 
            return 3.14 * (Radius * Radius);
        }
    }
}
