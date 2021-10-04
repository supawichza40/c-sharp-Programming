using System;

namespace VirtualOverideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog lucky = new Dog("Lucky",5);
            Console.WriteLine($"Name:{lucky.Name} Age:{lucky.Age}");
            lucky.MakeSound();
            lucky.Play();
            lucky.Eat();
            lucky.Play();

        }
    }
}
