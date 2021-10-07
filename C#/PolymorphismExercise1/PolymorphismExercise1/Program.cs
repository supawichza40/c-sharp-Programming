using System;
using System.Collections.Generic;

namespace PolymorphismExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car = new List<Car>
            {
                new Audi(200,"blue","A4"),
                new BMW(250,"red","M3")
                //this is part of polymorphism,We can use subclass instead of the base class when working with list due to implicit conversion

            };
            //this is equivalent to this
            //var Car2 = new List<Car>
            //{
            //    new (Car) Audi(200,"blue","A4")
            //};

            foreach (var car in Car)
            {
                car.Repair();
                /*
                 * this is part of polymorphism,it even thought call the method inside a car class, it know which one is the type Audi and BMW
                 * since at run time, it know which derive class each object belong to and invoke that function.
                 */

            }

            //Polymorphism at work
            Car bmwZ3 = new BMW(200, "black", "Z3"); //this will just print out the car function
            BMW bmwZ3_2 = new BMW(199, "black", "Z3");//this will print out the bmw function due to we create BMW object and the new keyword got trigger.
            //BMW bmwZ3_3 = new Car(200, "blue"); // this will give us error, due to we cannot implicitely convert a base class to derive class.
            bmwZ3.ShowDetail();
            bmwZ3_2.ShowDetail();
            //the new keyword mean that if you create an object of me, then you can use my method.

            //How can we use the base class function instead of derive class function eventhouhgt we have derive class.
            Car car2 = bmwZ3_2;//this is an implicit conversion, it is equivalent to
            //Car car2 = (Car)bmwZ3_2; is the same as Car car2 = bmwZ3_2 due to implicit conversion;

            car2.ShowDetail();
            bmwZ3.SetCarIDInfo(1234, "Supavich Aussawa");
            bmwZ3.GetCarIDInfo();
            bmwZ3_2.GetCarIDInfo();
        }

    }
}
