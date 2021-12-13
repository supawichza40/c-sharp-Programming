using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> lol = new List<int>();
            //Func<int, int, int> addThenMultiply = (a, b) => ((a + b )* 2);
            //Console.WriteLine(addThenMultiply(2,2));
            //int num = 0;
            //Action<int, int> hell = (a, b) => Console.WriteLine((a+b)*2);
            //hell(1,2);

            int? value = null;
            //Null coelescing operator
            int value2 = value ?? 10;
            int? value3 = null;
            Console.WriteLine(value2);

            //Normal if statement
            if (value !=null)
            {
                value3 = value;
            }
            else 
            {
                value3 = 10;
            }
            //Ternary Operator using null
            int value4 = (value != null) ? value.GetValueOrDefault() : 10;

            //Dynamic

            dynamic numb = 10;
            numb = "Hello";
            Console.WriteLine(numb);
            
            


            



            

        }
       
        
    }
}
