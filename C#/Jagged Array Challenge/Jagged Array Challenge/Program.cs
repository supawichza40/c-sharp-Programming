using System;

namespace Jagged_Array_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored.
            string[][] friendJaggedArray = new string[2][];
            friendJaggedArray[0] = new string[] { "Angela","Emily"};
            friendJaggedArray[1] = new string[] { "Dear", "Joy" };

            for (int i = 0; i < friendJaggedArray.Length; i++)
            {
                for (int j = 0; j < friendJaggedArray[i].Length; j++)
                {
                    Console.WriteLine(friendJaggedArray[i][j]);
                }
            }

        }
    }
}
