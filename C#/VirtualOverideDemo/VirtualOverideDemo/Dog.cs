using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverideDemo
{
    class Dog:Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name,int age) : base(name,age)
        {
            IsHappy = true;
        }
        public override void Eat()
        {
            //this is how we call eat in the base method
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof!!!!!");
        }
        public override void Play()
        {
            if (IsHappy)
            {
                Console.WriteLine($"This {Name} is playing ");
                base.Play();
            }
            else
            {
                Console.WriteLine($"The {Name} is not happy, cannot play");
            }
        }

    }
}
