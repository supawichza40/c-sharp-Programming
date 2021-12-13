using ICalculatorInputService;
using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput us = new UserInput(new KeyBoardReader());
            List<string> input = us.GetInput();
            ProcessInput pc = new ProcessInput();
            var result =pc.CalculateInput(input);
            Console.WriteLine($"Your answer is: {result}");
            Console.ReadKey();
        }
    }
}
