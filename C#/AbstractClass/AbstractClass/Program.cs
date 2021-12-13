using System;
using System.Collections.Generic;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new TriangleAbstract();
            s.PrintSize();
            ShapePoly sp = new ShapePoly();
            sp.PrintShape();

            Triangle t = new Triangle();
            t.PrintShape();

            Square sq = new Square();
            sq.PrintShape();
            List<ShapePoly> ls_shape = new List<ShapePoly>();
            ls_shape.Add(new Triangle());
            ls_shape.Add(new Square());
            foreach (var item in ls_shape)
            {
                item.PrintShape();
            }
        }

    }
    abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void PrintSize()
        {
            Console.WriteLine($"The Height: {Height} The Width:{Width}");
        }
        public void size()
        {
            Console.WriteLine("Hello");
        }

    }
    class TriangleAbstract : Shape
    {

    }
    class ShapePoly
    {
        public int Height { get; set; }
        public int Width { get; set; }
        
        public void PrintShape()
        {
            Console.WriteLine("I am a Shape");
        }

    }
    class Triangle : ShapePoly
    {
        public void PrintShape()
        {
            Console.WriteLine("I am a Triangle");
        }

    }
    class Square : ShapePoly
    {
        public void PrintShape()
        {
            Console.WriteLine("I am a square");
        }
    }
}
