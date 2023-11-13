using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._11Interfaces._06HerdarXCumprirContrato.Entities.Enums;

namespace CSharp._11Interfaces._06HerdarXCumprirContrato.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();

        protected AbstractShape(Color color)
        {
            Color = color;
        }
    }
}
