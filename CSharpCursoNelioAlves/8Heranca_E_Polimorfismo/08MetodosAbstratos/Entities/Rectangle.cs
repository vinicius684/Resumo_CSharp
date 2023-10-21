using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities.Enums;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities
{
    internal class Rectangle_ : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle_() { }

        public Rectangle_(Color color, double width, double height) : base(color) { 
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }
    }
}
