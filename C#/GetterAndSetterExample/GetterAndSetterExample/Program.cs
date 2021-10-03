using System;

namespace GetterAndSetterExample
{



    public class Human
    {
        private string naame;
        private string surname;

        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human dear = new Human();
            dear.Name = "Supavich";
            dear.Surname = "Aussawa";
            Console.WriteLine($"My name is {dear.Name} {dear.Surname}");
        }
    }

}
