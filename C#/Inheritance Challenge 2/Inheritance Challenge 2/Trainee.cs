using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Trainee : Employee
    {
        public int WorkingHour { get; set; }
        public int SchoolHour { get; set; }

        //this way of constructing a constructor is more preferred since it is more efficient.
        public Trainee(string firstName, string lastName, int salary, int workingHour,int schoolHour): base(firstName, lastName, salary)
        {
            WorkingHour = workingHour;
            SchoolHour = schoolHour;
        }
        public void Learn()
        {
            Console.WriteLine("I am learning, please teach me.");
        }
        public override void Work()
        {
            Console.WriteLine("Trainee: {0} {1} Hour of work:{2} School Hour:{3}",FirstName,LastName,WorkingHour,SchoolHour);
        }
        public override string ToString()
        {
            return String.Format("Trainee: {0} {1} Hour of work:{2} School Hour:{3}", FirstName, LastName, WorkingHour, SchoolHour);
        }

    }
}
