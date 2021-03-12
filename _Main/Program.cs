using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;

namespace SadConsoleGame
{
    public static class Program
    {
        static int width = 200;
        static int height = 50;

        static void Main()
        {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(width, height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        static void Init()
        {
            var consoleParent = new Console(width, height);

            consoleParent.Position = new Point(0, 0);
            consoleParent.Fill(null, Color.DarkBlue, null);
            consoleParent.Print(1, 1, $"I'm the root parent");

            var consoleChild = new Console(25, 4)
            {
                Parent = consoleParent,
                Position = new Point(32, 0)
            };
            consoleChild.Fill(null, Color.DarkGray, null);
            consoleChild.Print(1, 1, "I'm a child with a child");

            var consoleChild2 = new Console(25, 4);
            consoleChild2.Position = new Point(0, 5);
            consoleChild2.Fill(null, Color.DarkGreen, null);
            consoleChild2.Print(1, 1, "I'm a child");
            consoleChild2.Parent = consoleChild;
            consoleChild2.Components.Add(new ChangeParentComponent());


            consoleParent.IsFocused = true;
            consoleParent.Components.Add(new MyKeyboardComponent());
            consoleParent.Components.Add(new MyMouseComponent());
            consoleParent.MouseMove += Console_MouseMove; // See function in this class for purpose
            Global.CurrentScreen = consoleParent;

            consoleParent.Components.Add(new MouseMoveComponent());

            Global.CurrentScreen = new MapScreen();
            Global.CurrentScreen.IsFocused = true;
        }

        private static void Console_MouseMove(object sender, SadConsole.Input.MouseEventArgs e)
        {
            // see Hook in Init() for application
            var console = (Console)sender;

            console.Print(1, 1, $"Mouse moving at {e.MouseState.CellPosition}          ");

            if (e.MouseState.Mouse.LeftButtonDown)
                console.Print(1, 2, $"Left button is down");
            else
                console.Print(1, 2, $"                   ");
        }
    }
}
