using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise1
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }


        //We are going to create has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();
        public void SetCarIDInfo(int idNum,string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}",carIDInfo.IDNum,carIDInfo.Owner);
        }

        public Car(int hP,string color)
        {
            HP = hP;
            Color = color;
        }
        public void ShowDetail()
        {
            Console.WriteLine("Horse Power:{0} Color:{1}",HP,Color);

        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }

    }
}
