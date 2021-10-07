using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise1
{
    //This read as Audi is a Car
    class Audi:Car
    {
        private string brand = "Audi";
        public string Model { get; set; }
        public Audi(int hP, string color, string model) : base(hP, color)
        {
            Model = model;

        }
        public new void ShowDetail()
        {
            Console.WriteLine("HP:{0} Color:{1} Model:{2} Brand:{3}", HP, Color, Model, brand);
        }
        public override void Repair()
        {
            Console.WriteLine("Audi {0} is repaired", Model);
        }

    }

}
