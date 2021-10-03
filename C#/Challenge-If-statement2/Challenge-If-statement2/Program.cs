using System;

namespace Challenge_If_statement2
{
    class Program
    {
        /*
         * Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.
        */
        public static int highscore = 0;
        public static string highscorePlayer = "";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What is your name?");
                string playerName = Console.ReadLine();
                Console.WriteLine("What is your highscore?");
                string stringScore = Console.ReadLine();
                int score;
                bool validScore = Int32.TryParse(stringScore, out score);
                if (validScore)
                {
                    checkHighScore(score, playerName);
                }
                else
                {
                    Console.WriteLine("Invalid Score, Please try again.");
                }
            }


        }

        public static void checkHighScore(int playerScore, string playerName)
        {
            if (playerScore > highscore)
            {
                Console.WriteLine($"New highscore is {playerScore}");
                Console.WriteLine($"New highscore holder is {playerName}");
                highscore = playerScore;
                highscorePlayer = playerName;
            }
            else if (highscore > playerScore)
            {
                Console.WriteLine($"The old highscore of {highscore} could not be broken and it still held by {highscorePlayer}");

            }
            else
            {
                Console.WriteLine("They are evenly match, therefore the old score will be granted.");
            }
        }
    }
}
