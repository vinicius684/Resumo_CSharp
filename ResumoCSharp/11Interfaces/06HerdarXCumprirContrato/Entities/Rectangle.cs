using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._11Interfaces._06HerdarXCumprirContrato.Entities.Enums;

namespace CSharp._11Interfaces._06HerdarXCumprirContrato.Entities
{
    internal class Rectangle_ : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle_(Color color, double width, double height) : base(color) { 
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }

        public override string ToString()
        {
            return Color + "" + Width + "" + Height;
        }
    }
}
