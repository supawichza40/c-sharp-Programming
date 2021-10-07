using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public int Salary { get; set; }

        public Employee(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public virtual void Work()
        {

        }
        public void Pause()
        {

        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", FirstName, LastName, Salary);
        }


    }
}
