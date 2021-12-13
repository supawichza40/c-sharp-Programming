using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action listOfFunction = PrintHello;
            listOfFunction += PrintWorld;
            listOfFunction += PrintName;
            listOfFunction();

        }
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public static void PrintWorld()
        {
            Console.WriteLine("World");
        }
        public static void PrintName() {
            Console.WriteLine("Supavich");
        }
    }
}
