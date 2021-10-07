using System;

namespace Inheritance_Challenge_2
{
    class Program
    {
        /*
         Create a main class with the Main Method, then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().

Create a deriving class boss with the property CompanyCar and the method Lead().  Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().

Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

Don’t forget to create constructors.

Create an object of each of the three classes (with arbitrary values)

and call the methods, Lead() of Boss and Work() of Trainee.

Just print out the respective text, what the respective employees do.
E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.
          
          
         */
        static void Main(string[] args)
        {
            Boss supa = new Boss("Supavich", "Aussawa", 1000000, "Ferrari");
            Trainee emily = new Trainee("Vachiraya", "Buranasiri", 20000, 10, 8);
            Console.WriteLine(supa.ToString());
            supa.Lead();
            Console.WriteLine(emily.ToString());
            emily.Learn();
        }
    }
}
