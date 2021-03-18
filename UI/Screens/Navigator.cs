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

			Button abbey = new Button(buttonWidth, buttonHeight)
			{
				// ~Hire, ~fire, promote, and direct other monks at your abbey. Designate successors to your abbothood.
				// Expand the building

				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Abbey",
			};
			Add(abbey);

			Button library = new Button(buttonWidth, buttonHeight)
			{
				// View the acquired books in your collection

				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Library",
			};
			Add(library);

			Button study = new Button(buttonWidth, buttonHeight)
			{
				// Assign research tasks to yourself or others

				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Study",
			};
			Add(study);

			// Special Books

			Button accounts = new Button(buttonWidth, buttonHeight)
			{
				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Accounts",
			};
			Add(accounts);

			Button encyclopaedia = new Button(buttonWidth, buttonHeight)
			{
				// Articles about flora, fauna, minerals, villagers, merchants, cultures, religions, languages, thinkers
				// Links to books

				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Encyclopaedia",
			};
			Add(encyclopaedia);

			Button policies = new Button(buttonWidth, buttonHeight)
			{
				// Your exegesis of your church's teachings. Or, your druthers.
				// Also, the laws of the land, which you should not violate.

				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Policies",
			};
			Add(policies);


			List<string> buttonUnlocks = new List<string>()
			{
				"Accounts", // Accounts - Your personal accounts.
				"Alchaemica", // Alchemy - Test disease samples, plants, minerals. Make things out of them.
				"Astronomica", // Astronomy - Predict the weather and much more.
				"Botanica", // Botany - Study and breed plants for whichever purposes you choose
				"Ecologica", // Ecology - Assessing and setting policy for natural resources, to include hunting, foraging, farming, geology
				"Economica", // Economics - Assessing and setting policy for productive work and its products
				"Epomenologica", // Statistics - Choose variables and see their correlations
				"Genealogica", // Genealogy - Analyze the occurrence of genetic traits in villagers to avoid mishaps.
				"Oenologica",  // Winecraft
				"Statistica", // Statistics - 
				"Theologica", // Theology - Figure out the bizarre dynamics of the ProcGen Pantheon
				"Telethurgica", // Ritecraft - Construct Rituals to make Peasants take their medicine
				"Zythologica", // Beercraft
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