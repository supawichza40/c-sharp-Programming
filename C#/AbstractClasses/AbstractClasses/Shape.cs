using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Shape
    {

        public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"\n The name of the shape is {Name}");
        }
        public abstract double Volumn();

    }
}
