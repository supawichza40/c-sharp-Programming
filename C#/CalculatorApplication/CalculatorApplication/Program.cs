using System;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //This application will do two value operations, including Add,Subtract,Multiply and Divide.
        }

        static void Addition(int number1, int number2)
        {
            Console.WriteLine($"The Addition of number {number1} and {number2} is {number1+number2}");
        }
        static void Subtraction(int number1,int number2)
        {
            Console.WriteLine($"The Addition of number {number1} and {number2} is {number1 - number2}");
        }
        static void Multiplication(int number1,int number2)
        {
            Console.WriteLine($"The Addition of number {number1} and {number2} is {number1 * number2}");
        }
        static void Division(int number1, int number2)
        {
            try
            {

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("You are trying to divide by zero, please try again");
            }
        }

    }
}
