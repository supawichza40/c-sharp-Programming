using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class AudioSystem
    {
        public AudioSystem()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
            //This will add method to the GameEventManager deligate not assign.
        }
        public void StartGame()
        {
            Console.WriteLine("Audio System started...");
            Console.WriteLine("Playing Audio...");
        }
        public void GameOver(){
            Console.WriteLine("Audio System Stopped");
        }

    }
}
