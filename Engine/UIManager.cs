using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using MMS.UI.Screens;
using MMS.UI.Screens;

using SadConsole;
using SadConsole.Controls;

using Console = SadConsole.Console;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace MMS.Engine
{
	public class UIManager : ContainerConsole
	{
		// Consoles should be roughly parchment colored, from dark to light as the topmost is displayed

		public Window WorkDesk;
		public MessageLog MessageLog;
		public StatusWindow StatusWindow;
		public Navigator Navigator;

		public const int height_1_4 = Program.width * 1 / 4;
		public const int height_3_4 = Program.height * 3 / 4;
		public const int width_1_4 = Program.width * 1 / 4;
		public const int width_1_8 = Program.width * 1 / 8;
		public const int width_3_4 = Program.width * 3 / 4;

		public UIManager()
		{
			IsVisible = true;
			IsFocused = true;

			Parent = Global.CurrentScreen;
		}

		public void Init()
		{
			CreateWindows();

			UseMouse = true;
		}

		public void CreateWindows()
		{
			int navigatorWidth = Program.width / 8;
			int mainWindowWidth = Program.width - navigatorWidth;
			int mainWindowHeight = Program.height;
			int navigatorHeight = Program.height;

			WorkDesk = new Window(mainWindowWidth, mainWindowHeight)
			{
				CanDrag = false,
				Title = "Placeholder".Align(HorizontalAlignment.Center, mainWindowWidth),
			};
			Children.Add(WorkDesk);
			WorkDesk.Show();

			#region Navigator 

			Navigator = new Navigator(navigatorWidth, navigatorHeight)
			{
				Position = new Point(Program.width * 7 / 8, 0),
				UseMouse = true,
			};
			Children.Add(Navigator);
			Navigator.Show();


			#endregion

			MessageLog = new MessageLog(Program.width, height_1_4, "Log")
			{
				Position = new Point(0, height_3_4),
				CanDrag = false,
				UseMouse = true,
			};
			Children.Add(MessageLog);
			MessageLog.Show();
		}

		private static void Console_MouseMove(object sender, SadConsole.Input.MouseEventArgs e)
		{
			var console = (Console)sender;

			//if (e.MouseState.Mouse.LeftButtonDown)
			//	console.Print(1, console.Height - 5, $"You've clicked on {e.MouseState.CellPosition}        ");
			//else
			//	console.Print(1, console.Height - 5, $"                                                           ");
		}

		private static void Console_MouseClicked(object sender, SadConsole.Input.MouseEventArgs e)//+
		{
			//var console = (SadConsole.Console)sender;
			//StringBuilder seenString = new StringBuilder("You see:");

			//TileBase seenTile = Program.World.CurrentMap.GetTileAt<TileBase>(e.MouseState.CellPosition);
			//if (seenTile != null)
			//	seenString.Append($" {seenTile.Name},");

			//List<Entity> seenEntities = Program.World.CurrentMap.GetEntitiesAt<Entity>(e.MouseState.CellPosition);
			//if (seenEntities != null)
			//	foreach (Entity entity in seenEntities)
			//		seenString.Append($" {entity.Name},");

			//seenString.Remove(seenString.Length - 1, 1);                    //trim comma

			//Program.UIManager.MessageLog.AddTextNewline(seenString.ToString());
		}

		public bool IsKeyReleased(Keys input) =>
			Global.KeyboardState.IsKeyReleased(input);

		public bool IsKeyPressed(Keys input) =>
			Global.KeyboardState.IsKeyPressed(input);

		public void CreateMainWindow(int width, int height, string title)
		{
		}
	}
}
