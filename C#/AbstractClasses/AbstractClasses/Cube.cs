using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Cube : Shape
    {
        public double Length { get; set; }

        public override double Volumn()
        {
            double volumn = Math.Pow(Length, 3);
            return volumn;
        }
        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} has a length of {Length}");
            Console.WriteLine($"The volumn of the {Name} is {Volumn()}");

        }
    }
}
