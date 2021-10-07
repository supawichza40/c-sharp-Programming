using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise1
{
    //BMW is a car(general idea of inheritance)
    class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }
        public BMW(int hP,string color,string model):base(hP,color)
        {
            Model = model;

        }
        public new void ShowDetail()
        {
            Console.WriteLine("HP:{0} Color:{1} Model:{2} Brand:{3}",HP,Color,Model,brand);
        }
        public override void Repair()
        {
            Console.WriteLine("BMW {0} is repaired",Model);
        }
    }
}
