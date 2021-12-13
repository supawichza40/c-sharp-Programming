using System;
using System.Linq.Expressions;

namespace GenericCalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic val = Calculator.Addition<double>(10, 100.001);
            Console.WriteLine(val);
        }
    }
    //This can control the type being use for each level of class and method.
    class Calculator
    {
        public static T Addition<T>(T number1,T number2) //This will control the type being pass to the parameter.
        {
            try
            {
                dynamic val1 = number1;
                dynamic val2 = number2;

                return val1 + val2;

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid type of value, please try again");
            }
            return default;

        }
    }
}
