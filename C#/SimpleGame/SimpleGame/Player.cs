using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Player
    {
        public string PlayerName { get; set; }
        public Player(string name)
        {
            this.PlayerName = name;
            GameEventManager.OnGameOver += GameOver;
            GameEventManager.OnGameStart += StartGame;

        }
        public void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID:{PlayerName}");
        }
        public void GameOver()
        {
            Console.WriteLine($"Removing Player with ID :{PlayerName}");
        }
    }
}
