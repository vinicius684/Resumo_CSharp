using CSharp._12Generics_Set_Dictionary._05ComoColecoesHashTestamIgualdade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._12Generics_Set_Dictionary._05ComoColecoesHashTestamIgualdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 =====Como as Coleções Hash testam igualdade=====
                    Obs:Coleções Hash, são coleções que indexam seu elementos com base em um valor Hash(Ex:HashSet; Dictionary)
                    
                    -Se GetHashCode e Equals estiverem implementados:
                        Primeiro GetHashCode.Se der igual, usa Equals para confirmar (compara os valores dos atributos)

                    -Se GetHashCode e Equals não estiverem implementados:
                        Tipo referência: compara as referências dos objetos
                        Tipo Valor: compara os valores dos atributos
             */

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Note", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Note",1200.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(3, 4);
            Console.WriteLine(b.Contains(p));
        }
    }
}
