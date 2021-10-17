using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        public void StartGame()
        {
            Console.WriteLine("Rendering Engine started..");
            Console.WriteLine("Drawing visuals.....");
        }
        public void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
