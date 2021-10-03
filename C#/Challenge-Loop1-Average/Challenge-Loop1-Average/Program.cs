using System;

namespace Challenge_Loop1_Average
{
    class Program
    {
        /*
         * Imagine you are a developer and get a job in which you need to create a program for a teacher. He needs a program written in c# that calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
So the tool should check if the entry is a number and should add that to the sum. Finally once he is done entering scores, the program should write onto the console what the average score is.
The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
Test your program thoroughly.
        */
        static void Main(string[] args)
        {
            float sum = 0.0f;
            float studentScore = 0.0f;

            int counter = 0;
            string studentScoreString = "";
            while (!studentScoreString.Equals("-1"))
            {
                Console.WriteLine("What is the score of the next student?");
                studentScoreString = Console.ReadLine();
                if (studentScoreString.Equals("-1"))
                {
                    break;
                }
                try
                {
                    studentScore = float.Parse(studentScoreString);
                    sum = sum + studentScore;
                    counter += 1;
                }
                catch (Exception)
                {

                    Console.WriteLine("Please input a number only!");
                }
            }
            Console.WriteLine($"The total score is {sum} with {counter} student and the average score is {sum/counter}");
        }
    }
}
