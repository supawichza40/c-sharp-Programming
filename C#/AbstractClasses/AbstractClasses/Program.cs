using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube1 = new Cube(10);
            cube1.GetInfo();
            Sphere sphere1 = new Sphere(5);
            sphere1.GetInfo();

            Shape[] allShapeArray = { new Sphere(4), new Cube(3) };
            foreach (Shape shape in allShapeArray)
            {
                shape.GetInfo();
            }
        }
    }
}
