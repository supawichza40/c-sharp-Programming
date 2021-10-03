using System;

namespace ChallengeMethod
{
    class Program
    {
        /*
In this challenge you will deepen your understanding for methods.
Please go ahead and create three variables with names of your friends.
Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). 

Greet all your three friends.
         */

        static void Main(string[] args)
        {
            string friend1 = "Emily", friend2 = "Angela",friend3 = "Supavich";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

        }
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine($"Hi {friendName}, my friend!");

        }
    }
}
