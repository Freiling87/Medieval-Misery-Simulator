using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;

namespace SadConsoleGame
{
    public static class Program
    {
        static void Main()
        {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(80, 25);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        static void Init()
        {
            var consoleParent = new Console(30, 4);
            var consoleChild = new Console(25, 4);

            consoleParent.Position = new Point(0, 5);
            consoleParent.Fill(null, Color.DarkBlue, null);
            consoleParent.Print(1, 1, $"I'm the root parent");

            consoleChild.Position = new Point(32, 0);
            consoleChild.Fill(null, Color.DarkGray, null);
            consoleChild.Print(1, 1, "I'm a child with a child");
            consoleChild.Parent = consoleParent;

            SadConsole.Global.CurrentScreen = consoleParent;
        }

    }
}
