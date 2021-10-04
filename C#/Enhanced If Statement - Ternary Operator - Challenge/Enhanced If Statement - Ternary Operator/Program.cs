using System;

namespace Enhanced_If_Statement___Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.
            */
            string strTemp;
            Console.WriteLine("What is the temperature?");
            strTemp = Console.ReadLine();
            string sentence = "";
            int temp = 0;
            bool isNumber = Int32.TryParse(strTemp, out temp);
            sentence = isNumber == false ? "Not a valid Temperature" : temp <= 15 ? "it is too cold here" : temp >= 16 && temp <= 28 ? "it is ok" : "it is hot here";
            Console.WriteLine($"{sentence}");
        }
    }
}
