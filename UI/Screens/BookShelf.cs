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
		static int _height;
		static int _width;
		static int buttonHeight = 3;
		static int buttonGutter = 1;
		int buttonWidth;

		public static Dictionary<string, string> buttonTitles = new Dictionary<string, string>()
		{
			{ "Alchemy",		"  { A L C H Æ M I C A }  " }, // Alchemy - Test disease samples, plants, minerals. Make things out of them.
			{ "Astronomy",		"  O ○ (Astronomica) ○ O  " }, // Astronomy - Predict the weather and much more.
			{ "Botany",			"  ☼~§~╢ Botanica ╠═╤╧═( )" }, // Botany - Study and breed plants for whichever purposes you choose
			{ "Ecology",		"  (▲▼≈= Ecologica ▲▼≈=)  " }, // Ecology - Assessing and setting policy for natural resources, to include hunting, foraging, farming, geology
			{ "Economy",        " ╠═O══╡ Œconomica ╞══O═╣ " }, // Economics - Assessing and setting policy for productive work and its products 
			{ "Statistics",     "  ╒═╛ Epomenologica ╒═╛  " }, // Statistics - Choose variables and see their correlations
			{ "Genealogy",		" ║ ○-  Genealogica  -○ ║ " }, // Genealogy - Analyze the occurrence of genetic traits in villagers to avoid mishaps.
			{ "Theology",       " ╠╪O╪╣ Theologica  ╠╪O╪╣ " }, // Theology - Figure out the bizarre dynamics of the ProcGen Pantheon
			{ "Rituals",        "  «««  Telethurgica  »»» " }, // Ritecraft - Construct Rituals to make Peasants take their medicine
			{ "Brewing",        " ╒╧╤╛  Zymologica   ╘╤╧╕ " }, // Brewery - Make beer, wine, or whatever the fuck they drink in your world!
		};



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
			Print(0, 0, "Booke Shaelfe".Align(HorizontalAlignment.Center, Width), Color.Gold, Color.SaddleBrown);
		}

		public void RefreshButtons()
		{
			int buttonIndex = 2 - buttonHeight;

			// NonBooks, to be added to a separate window?

			Button town = new Button(buttonWidth, buttonHeight)
			{
				Position = new Point(buttonGutter, buttonIndex += buttonHeight),
				Text = "Town",
			};
			town.Theme = new BookButtonTheme(BookButtonEnum.Town);
			Add(town);

			Button abbey = new Button(buttonWidth, buttonHeight)
			{
				// ~Hire, ~fire, promote, and direct other monks at your abbey. Designate successors to your abbothood.
				// Expand the building
				// Manage your accounts

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

			buttonIndex++;

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

			// Discoverable books


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