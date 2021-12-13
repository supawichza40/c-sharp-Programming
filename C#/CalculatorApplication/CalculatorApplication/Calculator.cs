using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Calculator
    {
        public int value1 { get; set; }
        public int value2 { get; set; }

        public Calculator(int input1,int input2)
        {
            value1 = input1;
            value2 = input2;
        }

        public void Addition()
        {
            Console.WriteLine($"The Addition of number {value1} and {value2} is {value1 + value2}");
        }
        public void Subtraction()
        {
            Console.WriteLine($"The Subtraction of number {value1} and {value2} is {value1 - value2}");
        }
        public void DisplayAllOperation()
        {
            Addition();
            Subtraction();
        }
        public void Division()
        {
            try
            {

                Console.WriteLine($"The Division of number {value1} and {value2} is {value1 / value2}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Trying to divide by zero");
            }

         
        }

    }
}
