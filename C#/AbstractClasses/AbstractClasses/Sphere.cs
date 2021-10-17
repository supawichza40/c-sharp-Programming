using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public override double Volumn()

        {


            double volumn = ((double)4 / (double)3) * 3.14 * Math.Pow(Radius, 3);
            return volumn;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The shape of {Name} has radius of {Radius}");
            Console.WriteLine($"The volumn of {Name} is {Volumn()}");
        }
    }
}
