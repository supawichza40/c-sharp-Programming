using System;
using System.Collections.Generic;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Print();
            Car c = new Car();
            c.Print();
            //This does work as intended, but usually we use covariance to pass our data

            List<Vehicle> list_vehicle = new List<Vehicle>();
            list_vehicle.Add(new Vehicle());
            list_vehicle.Add(new Car());
            foreach (var item in list_vehicle)
            {
                item.Print();
            }
            //As you can see, we cannot get the Vehicle object that assign car object to print what we expected.
        }

    }
    class Vehicle
    {
        
        public int Year { get; set; }

        public void Print()
        {
            Console.WriteLine("This is a Vehicle");
        }
    }
    class Car : Vehicle
    {
        public void Print()
        {
            Console.WriteLine("This is a Car");
        }
    }
}
