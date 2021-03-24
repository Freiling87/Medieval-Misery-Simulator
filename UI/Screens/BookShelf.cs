using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;

using MMS.Engine;
using MMS.UI.Controls;
using MMS.UI.Themes;

using SadConsole;
using SadConsole.Controls;

namespace MMS.UI.Screens
{
	public class BookShelf : ControlsConsole
	{
		public List<BookButtonTitles> buttonUnlocks;

		static int _height;
		static int _width;
		static int buttonHeight = 3;
		static int buttonGutter = 1;
		static int bookshelfHeader = 2;
		int buttonWidth;
		int buttonIndex = bookshelfHeader - buttonHeight;

		public BookShelf(int width, int height) : base(width, height)
		{
			_height = height;
			_width = width;
			buttonWidth = _width - buttonGutter * 2;

			RefreshButtons();
		}

		protected override void OnInvalidate()
		{
			Fill(Color.AntiqueWhite, Color.SaddleBrown, null); 
			Print(0, 0, "Booke Shælfe".ToAscii().Align(HorizontalAlignment.Center, Width), Color.Gold, Color.SaddleBrown);
		}

		public void RefreshButtons()
		{
			//Button abbey = new Button(buttonWidth, buttonHeight)
			//{
			//	// ~Hire, ~fire, promote, and direct other monks at your abbey. Designate successors to your abbothood.
			//	// Expand the building
			//	// Manage your accounts

			//	Position = new Point(buttonGutter, buttonIndex += buttonHeight),
			//	Text = "Abbey",
			//};
			//Add(abbey);

			//Button town = new Button(buttonWidth, buttonHeight)
			//{
			//	Position = new Point(buttonGutter, buttonIndex += buttonHeight),
			//	Text = "Town",
			//};
			//Add(town);

			//Button library = new Button(buttonWidth, buttonHeight)
			//{
			//	// View the acquired books in your collection

			//	Position = new Point(buttonGutter, buttonIndex += buttonHeight),
			//	Text = "Library",
			//};
			//Add(library);

			//Button study = new Button(buttonWidth, buttonHeight)
			//{
			//	// Assign research tasks to yourself or others

			//	Position = new Point(buttonGutter, buttonIndex += buttonHeight),
			//	Text = "Study",
			//};
			//Add(study);

			foreach (BookButtonTitles unlock in Program.Player.unlocksBookshelf)
				AddBookButton(unlock);
		}

		public void AddBookButton(BookButtonTitles title)
		{
			Button button = new Button(buttonWidth, buttonHeight)
			{
				Position = new Point(buttonGutter, buttonIndex += buttonHeight), // Add increment to call
				Text = title.ToString(),
			};
			button.Theme = new BookButtonTheme();
			Add(button);
		}
	}
}