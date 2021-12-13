using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are not allow to create an instance of a Shape class
            //Shape s = new Shape();//Interface and Abstract class cannot be instantiate


            //Method dispatching
            //If we do not use the keyword abstract,virtual etc., then the only function that all the base class and derived class will point to is the base function - this is called a static dispatch
            Small bg = new Big(); //When we do Covariance
            bg.Print();
            //output ---> I am part of small

            //To solve this, we need to mark the base function as virtual, so that we can override it in the derive class, and create a dynamic dispatching using the v table(virtual table).
            //and to access it base class, we just use base.<function>



            Triangle tr = new Triangle(10,20);
            tr.PrintHeight();
            tr.PrintWidth();

            Shape sh = new Triangle(10, 20);
            sh.PrintHeight();
            sh.PrintWidth();

        }
    }
    class Small
    {
        virtual public void Print()
        {
            Console.WriteLine("I am part of small");
        }
    }
    class Big : Small
    {
        override public void Print()
        {
            base.Print();
        }

    }
    abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }


        abstract public void PrintHeight();
        virtual public void PrintWidth()
        {
            Console.WriteLine($"WidthBase: {Width}");
        }
    }
    class Triangle : Shape
    {
        public Triangle(int height,int width)
        {
            Height = height;
            Width = width;
        }
        public override void PrintHeight()
        {
            //base.PrintHeight();//we cannot call an abstract method.
            Console.WriteLine($"Derive The height: {Height} The width: {Width}");
        }
        public override void PrintWidth()
        {
            Console.WriteLine("Derive Width");
        }
    }
    class Square : Shape
    {
        public override void PrintHeight()
        {
            throw new NotImplementedException();
        }
    }
}
