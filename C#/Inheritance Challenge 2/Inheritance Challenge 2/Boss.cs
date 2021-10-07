using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string firstName, string lastName,int salary,string companyCar): base(firstName,lastName,salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I am leading, Follow me and we can make it better.");
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", FirstName, LastName, Salary, CompanyCar);

        }
    }
}
