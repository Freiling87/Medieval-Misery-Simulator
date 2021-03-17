using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;

using MMS.Engine;

using SadConsole;
using SadConsole.Controls;

namespace MMS.UI.Screens
{
	public class Navigator : Window
	{
		static int _height;
		static int _width;
		static int buttonHeight = 3;
		static int buttonGutter = 1;
		int buttonWidth;

		public Navigator(int width, int height) : base(width, height)
		{
			_height = height;
			_width = width;
			buttonWidth = _width - buttonGutter * 2;

			RefreshButtons();
		}

		public void RefreshButtons()
		{


			int buttonIndex = 0;

			Button town = new Button(buttonWidth, buttonHeight)
			{
				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Town",
			};
			Add(town);

			Button encyclopaedia = new Button(buttonWidth, buttonHeight)
			{
				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Encyclopaedia",
			};
			Add(encyclopaedia);

			List<string> buttonUnlocks = new List<string>()
			{
				"Alchaemica",
				"Astronomica",
				"Botanica",
				"Telethurgica", // Ritecraft
				"Oenologica"
			};

			//foreach (string unlock in buttonUnlocks)
			//{
			//	if (Program.Player.unlocks.Contains(unlock))
			//	{
			//		AddButton(buttonIndex += buttonHeight, unlock);
			//	}
			//}
		}

		public void AddButton(int index, string name)
		{
			Button button = new Button(buttonWidth, buttonHeight)
			{
				Position = new Point(buttonGutter, index), // Add increment to call
				Text = name,
			};
			button.IsDirty = true;
			Add(button);
		}
	}
}