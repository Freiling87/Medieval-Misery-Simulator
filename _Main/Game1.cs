using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadRogueSharp
{
    public class Game1 : SadConsole.Game
    {
        public Game1() : base("", 80, 25, null)
        {

        }

        protected override void Initialize()
        {
            // Generally you don't want to hide the mouse from the user
            IsMouseVisible = true;

            // Finish the initialization of SadConsole before you start your game init
            base.Initialize();

            // Create your console
            var firstConsole = new SadConsole.Console(60, 25);

            firstConsole.FillWithRandomGarbage();
            firstConsole.Fill(new Rectangle(2, 2, 20, 3), Color.Aqua, Color.Black, 0);
            firstConsole.Print(3, 3, "Hello World!");

            SadConsole.Global.CurrentScreen = firstConsole;
        }
    }
}