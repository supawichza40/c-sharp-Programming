﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverideDemo
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }
        public Animal(string name,int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }
        public virtual void MakeSound()
        {
            
        }
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating!");
                IsHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry!");
            }
        }
        public virtual void Play()
        {
            if (IsHungry==true)
            {
                Console.WriteLine($"{Name} need to eat before can play");
            }
            else
            {
                Console.WriteLine($"{Name} is playing!");
                IsHungry = true;
            }
        }

    }
}
