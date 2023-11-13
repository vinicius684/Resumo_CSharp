using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._11Interfaces._06HerdarXCumprirContrato.Entities.Enums;

namespace CSharp._11Interfaces._06HerdarXCumprirContrato.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        { 
            Radius = radius;
        }

        public override double Area() { 
            return 3.14 * (Radius * Radius);
        }

        public override string ToString()
        {
            return Color +"" + Radius;
        }
    }
}
