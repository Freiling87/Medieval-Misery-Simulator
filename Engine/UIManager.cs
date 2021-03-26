using System;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using MMS.UI.Screens;
using MMS.UI.Wiki;

using SadConsole;
using SadConsole.Controls;

using Console = SadConsole.Console;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace MMS.Engine
{
	public class UIManager : ContainerConsole
	{
		// TODO: Consoles should be roughly parchment colored, from dark to light as the topmost is displayed

		public Window WorkDesk;
		public static MessageLog MessageLog;
		public StatusWindow StatusWindow;
		public BookShelf Bookshelf;

		public SadConsole.Themes.Colors ParchmentTheme;

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
			SetupCustomColors();
			CreateWindows();

			UseMouse = true;
		}

		private void SetupCustomColors()
		{
			ParchmentTheme = SadConsole.Themes.Colors.CreateDefault();

			// http://www.foszor.com/blog/xna-color-chart/

			Color parchment = Color.BurlyWood;
			Color ink = Color.DarkSlateGray;

			ParchmentTheme.ControlHostBack = parchment;
			ParchmentTheme.ControlBack = (parchment * 0.7f).FillAlpha();

			ParchmentTheme.ControlBackDark = (parchment * 0.7f).FillAlpha();
			ParchmentTheme.ControlBackLight = (parchment * 1.3f).FillAlpha();

			ParchmentTheme.ControlBackSelected = Color.HotPink;

			ParchmentTheme.Text = ink;
			ParchmentTheme.TextBright = ink;
			ParchmentTheme.TextDark = ink;
			ParchmentTheme.TextFocused = ink;
			ParchmentTheme.TextLight = ink;
			ParchmentTheme.TextSelected = ink;
			ParchmentTheme.TextSelectedDark = ink;
			ParchmentTheme.TitleText = ink;
			
			// Rebuild all objects' themes with the custom colours we picked above.
			ParchmentTheme.RebuildAppearances();

			// Now set all of these colours as default for SC's default theme.
			SadConsole.Themes.Library.Default.Colors = ParchmentTheme;
		}

		private void CreateWindows()
		{
			int totalHeight = Program.height;
			int totalWidth = Program.width;

			int bookshelfHeight = totalHeight;
			int bookshelfWidth = totalWidth / 4;

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

			LogMessage("Here's a test message with a {Person:James Johnson|Jimmy} hyperlink to fuck around with.");
		}

		public static void LogMessage(string text)
		{
			MessageLog.LogMessage(text);
		}

		private static void Console_MouseMove(object sender, SadConsole.Input.MouseEventArgs e)
		{
			var console = (Console)sender;
		}

		private static void Console_MouseClicked(object sender, SadConsole.Input.MouseEventArgs e)//+
		{
		}

		public bool IsKeyReleased(Keys input) =>
			Global.KeyboardState.IsKeyReleased(input);

		public bool IsKeyPressed(Keys input) =>
			Global.KeyboardState.IsKeyPressed(input);
	}
}
