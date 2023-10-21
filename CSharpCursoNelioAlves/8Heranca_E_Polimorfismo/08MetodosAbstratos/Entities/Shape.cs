﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities.Enums;

namespace CSharpCursoNelioAlves._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }

        public Shape(Color color) { 
                Color = color;
        }

        public abstract double Area(); 
        
        
    }
}
