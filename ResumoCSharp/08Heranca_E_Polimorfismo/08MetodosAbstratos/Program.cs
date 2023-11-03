using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities.Enums;
using CSharp._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities;
using CSharp._8Heranca_E_Polimorfismo._08MetodosAbstratos.Entities.Enums;

namespace CSharp._8Heranca_E_Polimorfismo._08MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =====Metodos=====
                  -Metodos que não possuem implementação  
            
                  -Metodos precisam ser abstratos quando a classe é genérica demais para conter sua implementação

                  -Se um classe possuir pelo menos um métodos abstrato, então esta classe também é abstrata

                  -Notação UML: metodo em itálico

                    ex: Superclasse Shape, com subclasses Retangle e Circle. Area() no shape será abstrata 
             */
            
           
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int nShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nShapes; i++)
            {
                Console.WriteLine("Shape #" + i + " data:");
                Console.Write("Rectangle or Circle (r/c)?");
                char r_C = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                
                if (r_C == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle_(color, width, height));
                }
                else {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(color, radius));
                }

            }
            Console.WriteLine("\nShape Areas");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area());
            }

        }
    }
}
