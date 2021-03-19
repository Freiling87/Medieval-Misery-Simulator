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
		public BookShelf Bookshelf;

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
			int totalHeight = Program.height;
			int totalWidth = Program.width;

			int bookshelfHeight = totalHeight;
			int bookshelfWidth = totalWidth / 8;

			int statusHeight = totalHeight / 6;
			int statusWidth = totalWidth;

			int mainWindowHeight = totalHeight- statusHeight;
			int mainWindowWidth = totalWidth - bookshelfWidth;

			WorkDesk = new Window(mainWindowWidth, mainWindowHeight)
			{
				CanDrag = false,
				Position = new Point(0, 0),
				Title = "Placeholder".Align(HorizontalAlignment.Center, mainWindowWidth),
			};
			Children.Add(WorkDesk);
			WorkDesk.Show();

			Bookshelf = new BookShelf(bookshelfWidth, bookshelfHeight)
			{
				Position = new Point(totalWidth - bookshelfWidth, totalHeight - bookshelfHeight),
			};
			Children.Add(Bookshelf);

			MessageLog = new MessageLog(statusWidth, statusHeight, "Log")
			{
				Position = new Point(totalWidth - statusWidth, totalHeight - statusHeight),
				CanDrag = false,
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
