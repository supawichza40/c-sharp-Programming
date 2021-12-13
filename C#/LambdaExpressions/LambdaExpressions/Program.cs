using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a multiplier function using lambda expression
            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;
            //This read as Create a function that take input of type int
            //and return int type, we will call it multiplier.
            //All the input n will go throught n*factor expression and return the result
            //to the multiplier.
            Console.WriteLine(multiplier(10));
            int number = 10;

            //normal predicate
            //Take anytype of input return boolean
            //1. FIRST WAY
            Predicate<string> isUpper = IsUpper;
            Console.WriteLine(isUpper("HELLOW"));
            //2. SECOND WAY USING ANONYMOUSE METHOD
            Predicate<string> isUpper2 = delegate (string input) { return input.Equals(input.ToUpper()); };
            Console.WriteLine(isUpper2("HELLOW"));
            //3. THIRD WAY USING LAMBDA EXPRESSION
            Predicate<string> isUpper3 = input => input.Equals(input.ToUpper());
            Console.WriteLine(isUpper3("HELLOW"));
            //4. FOURTH WAY USING FUNCTION WITH LAMBDA
            Func<string, bool> isUpper4 = input => input.Equals(input.ToUpper());
            Console.WriteLine(isUpper4("HELLOW"));



        }
        //Normal multiplier function
        public static int Multiplier(int number,int factor)
        {
            return number * factor;
        }
        //FIRST WAY OF USING PREDICATE
        public static bool IsUpper(string input)
        {
            return input.Equals(input.ToUpper());
        }
        //SECOND WAY OF USING PREDICATE
    }
}
