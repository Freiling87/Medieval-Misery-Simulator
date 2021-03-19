using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;
using Game = SadConsole.Game;
using MMS;
using MMS.UI;
using MMS.NonSpatial;

namespace MMS.Engine
{
    public static class Program
    {
        public const int width = 200;
        public const int height = 60;

        public static UIManager UIManager;
        public static GSManager GSManager;
        public static Player Player;
        public static World World;

        public static Random rndNum = new Random();

        static void Main()
        {

            System.Console.Write("test");
            SadConsole.Game.Create(width, height);

            //SadConsole.Game.Create("Cheepicus_12x12.font", GameWidth, GameHeight);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;
            SadConsole.Game.OnUpdate = Update;
            SadConsole.Game.Instance.Run();

            // Code below will not run until the game window closes.

            SadConsole.Game.Instance.Dispose();
        }

        static void Init()
        {
            UIManager = new UIManager();
            GSManager = new GSManager();
            World = new World();
            //Player Player = new Player();

            UIManager.Init();
        }

        private static void Update(GameTime time)
		{
		}

    }
}
