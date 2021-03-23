using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;
using Game = SadConsole.Game;
using MMS;
using MMS.UI;
using MMS.NonSpatial;
using Microsoft.Xna.Framework.Graphics;

namespace MMS.Engine
{
    public static class Program
    {
        public const int width = 240;
        public const int height = 80;

        public static UIManager UIManager;
        public static GSManager GSManager;
        public static Player Player;
        public static World World;

        public static Random rndNum = new Random();

        static void Main()
        {
            System.Console.Write("Test Pre-Run message");

            Game.Create("Fonts\\Andux_8x12.font", width, height);

            Game.OnInitialize = Init;
            Game.OnUpdate = Update;
            Game.Instance.Run();

            // Code below will not run until the game window closes.

            Game.Instance.Dispose();
        }

        static void Init()
        {
            Global.FontDefault = Global.FontDefault.Master.GetFont(Font.FontSizes.One);

            UIManager = new UIManager();
            GSManager = new GSManager();
            World = new World();

            UIManager.Init();
        }

        private static void Update(GameTime time)
		{
		}
    }
}
