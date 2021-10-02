using System;

namespace Challenge_DataTypeAndVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Now that you know how to declare and initialize Variables, please go ahead and create a variable for each of the primitive datatypes (you can find the list here). Leave the Object datatype out.
And also please initialize each variable with a working value.
Then create two values of type string. 
The first one should say "I control text"

The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.

Add each an output for each of the variables and write it onto the console. (WriteLine)
Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
Have fun :)
            */

            byte age = 24;
            Console.WriteLine(age);
            sbyte temperatureOutside = -10;
            Console.WriteLine(temperatureOutside);
            int accountBalance = 1000000;
            Console.WriteLine(accountBalance);
            uint totalAccountBalance = 4000000;
            Console.WriteLine(totalAccountBalance);
            short salaryPerMonth = 4000;
            Console.WriteLine(salaryPerMonth);
            ushort salaryPerMonth2 = 7000;
            Console.WriteLine(salaryPerMonth2);
            long speedOfLight = 3700000000000;
            Console.WriteLine(speedOfLight);
            ulong sizeOfUniverse = 999999999999999999;
            Console.WriteLine(sizeOfUniverse);
            float pi = 3.14159265f;
            Console.WriteLine(pi);
            double fraction = 3.15116946846548468;
            Console.WriteLine(fraction);
            char atSymbol = '@';
            Console.WriteLine(atSymbol);
            bool isSunny = true;
            Console.WriteLine(isSunny);
            string helloWorld = "Hello World";
            Console.WriteLine(helloWorld);
            decimal biggestDecimalNumber =555554654;
            Console.WriteLine(biggestDecimalNumber);
            string text = "I control text";
            string number = "10";
            int myNumberText = Int32.Parse(number);
            Console.WriteLine(myNumberText);

        }
    }
}
