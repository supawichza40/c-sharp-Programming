using System;

namespace RandomNumber
{
    class Program
    {
        enum position { one=1, two, three, four, five, six } //enum belong to a class not inside a main function
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{


            //    Random option = new Random();
            //    var answer = option.Next(1, 4);
            //    if (answer == 1)
            //    {
            //        Console.WriteLine("This is one");
            //    }
            //    else if (answer == 2)
            //    {
            //        Console.WriteLine("This is two");
            //    }
            //    else {
            //        Console.WriteLine("This is three");
            //    }
            //}

            //Lottery Generator
           
            Random lotteryNumber = new Random();

            Console.WriteLine("How many number would you like to generate? ");
            string numberToGenerateString = Console.ReadLine();
            int numberToGenerate = Int32.Parse(numberToGenerateString);
            Console.WriteLine("We are processing and calculating your number!");
            for (int i = 0; i < numberToGenerate; i++)
            {
                Console.WriteLine($"Position{i+1}: {lotteryNumber.Next(1,50)}");//This will generate a random number from 1-49 excluding 50
                System.Threading.Thread.Sleep(1000);
            }



        }
    }
}
