using System;
using System.Collections;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();
            studentTable.Add(1, 2);
            studentTable.Add("one", "two");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            int number = (int)studentTable[1];
            Console.WriteLine(number);
            string number2 = (string)studentTable["one"];
            Console.WriteLine(number2);

            foreach (int item in studentTable.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
