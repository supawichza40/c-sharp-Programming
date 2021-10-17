using System;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Version1 ====");
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");


            //version 1 = Normal way but if the system is complex, lot of error.
            audioSystem.StartGame();
            renderingEngine.StartGame();

            player1.StartGame();
            player2.StartGame();

            Console.WriteLine("Game is running....Press any key to end the game..");
            Console.ReadLine();
            audioSystem.GameOver();
            renderingEngine.GameOver();
            player1.GameOver();
            player2.GameOver();
            Console.WriteLine("==== Version1 ====");
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("====Version2===");
            //version 2 = Multi deligate with multiple method.
            GameEventManager.TriggerGameStart();
            Console.WriteLine("Gam");
            Console.WriteLine("Game is Running..Press any key to end the game");

            Console.ReadLine();

            GameEventManager.TriggerGameOver();
            Console.WriteLine("====Version2===");


        }
    }
}
