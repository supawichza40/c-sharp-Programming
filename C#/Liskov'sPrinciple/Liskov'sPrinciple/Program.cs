using System;
using System.Collections.Generic;

namespace Liskov_sPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Vehicle> vehicle_lst = new List<Vehicle>();
            //vehicle_lst.Add(new Car());
            //vehicle_lst.Add(new Car());
            //vehicle_lst.Add(new RacingCar());
            //foreach (var item in vehicle_lst)
            //{
            //    item.getInteriorWidth();
            //}
            Bird bird = new Bird();
            
            Bird ostrid = new Ostrid();//Liskov state that if we substitute a base class with derive or vice versa, if should not affect the behaviour of a class
                                       // meaning bird object could be able to fly even when you pass an ostrid.

            //Now we are following Liskov substitution principle since, the Ostrid does not have a fly function since bird class does not have and all behaviour resume as usual.
            //Apple a = new Orange();//Bad Design
            Fruit a = new Apple();
            //So you can put whatever object you want, that is base or derive but the behaviour should not be change and give expected behaviour, if not then our class does not follow liskov.
            a.GetColor();
            Apple b = new Apple();
            b.GetColor();

            FlyBird f = new FlyBird();
            FlyBird pigeon = new Pigeon();
            //To test for liskov, we use covariance, and it it the behaviour we want, then it fine.
            Pigeon p = new Pigeon();
            //Pigeon p = new FlyBird();
            f.Fly();
            pigeon.Fly();
            p.Fly();
            //p.Fly();
            Console.ReadKey();
            //Liskov substitution does not allow subclass to not implement it base function, it does not use or change it, it will break liskov
        }
    }
    abstract class Fruit
    {
        public abstract void GetColor();
    }
    class Apple : Fruit
    {
        public override void GetColor()
        {
            Console.WriteLine("Red");
        }
    }
    class Orange : Fruit
    {
        public override void GetColor()
        {
            Console.WriteLine("Orange");
        }
    }

    //class Orange:Apple
    //{
    //    override public void GetColor()
    //    {
    //        Console.WriteLine("I am orange");
    //    }
    //}
    //class Apple 
    //{
    //    public virtual void GetColor()
    //    {
    //        Console.WriteLine("I am  Red");
    //    }
    //}
    //Bad design since apple object is printing an orange color

    class Bird
    {

    }
    class FlyBird : Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
    
    class Pigeon : FlyBird
    {
        public override void Fly()
        {
            Console.WriteLine("I am a pigeon and fly higher");
        }
    }
    class Ostrid:Bird
    {

    }
    abstract class Vehicle
    {
        public virtual double getInteriorWidth()
        {
            return 10.0;
        }
    }
    class Car : Vehicle
    {
        public override double getInteriorWidth()
        {
            return getCabinWidth();
        }
        public double getCabinWidth()
        {
            Console.WriteLine("This is a cabin width inside car class");
            return 20.00;
        }
    }
    class RacingCar : Vehicle
    {
        public override double getInteriorWidth()
        {
            Console.WriteLine("I am in Racing Car and inside getInteriorWidth function");
            return getCockpitWidth();
        }
        public double getCockpitWidth()
        {
            return 20.00;
        }
    }
}
