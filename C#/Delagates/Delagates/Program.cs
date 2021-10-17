using System;
using System.Collections.Generic;

namespace Delagates
{
    class Program
    {
        public delegate bool FilterDelegate(Person p);
        public delegate int Del(int x);
        static void Main(string[] args)
        {
            ////Predicate is the name given to a unique delagates.
            //List<string> names = new List<string>() { "Supi", "Aussi", "Em" };



            //Console.WriteLine("Before");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            ////without the bracket, we are passing the method, not executing it.
            //Console.WriteLine("After");
            //names.RemoveAll(Filter);
            ////since the programmer creating RemoveAll Function, do not know what other programmer,
            ////will use their code, for, we can define our own function, and if true will remove it.
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };
            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult Only", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);
            FilterDelegate filter = delegate (Person p)
            {
                //anonymouse method.
                return p.Age >= 20 && p.Age <= 30;
            };
            DisplayPeople("Senior Again", people, filter);
            DisplayPeople("All people", people, 
                delegate (Person p) {
                    return true;
                }
                );

            //Lambda Expression

            string searchKeyword = "A";
            DisplayPeople("age>20 with search keyword:" + searchKeyword, people, p =>
            {
                if (p.Name.Contains(searchKeyword)&& p.Age >20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            //Expression lambda is for assignment.
            DisplayPeople("exactly 25 years old:", people, p => p.Age == 25);
            Del del = x => x * x;
            int multi = del(10);
            Del del2 = x => x + 25;
            int add = del2(10);
            Console.WriteLine("{0} {1}",multi,add);
           

        }
        static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
        {
            Console.WriteLine("============================");
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0},{1} years old",p.Name,p.Age);
                }
            }

            Console.WriteLine("============================");
        }
        //=========================FILTERS======================
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }
        static bool IsAdult(Person p)
        {
            return p.Age >= 18;

        }
        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
        //static bool Filter(string s)
        //{
        //    return s.Contains("i");

        //}
    }
}
