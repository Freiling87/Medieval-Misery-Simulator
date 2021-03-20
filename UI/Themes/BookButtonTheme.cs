using System;
using System.Collections.Generic;
using System.Text;

using SadConsole;
using SadConsole.Controls;
using SadConsole.Themes;

namespace MMS.UI.Themes
{
	public enum BookButtons
	{
		Accounts,
		Alchemy,
		Astronomy,
		Botany,
		Ecology,
		Economy,
		Genealogy,
		Statistics,
		Theology,
		Rituals,
		Zymology,
		Template
	}
	
	class BookButtonTheme : ButtonTheme
	{
		private static BookButtons title;

		public static Dictionary<string, string> buttonTitles = new Dictionary<string, string>()
		{
			{ "Alchemy",        "  { A L C H Æ M I C A }  " }, // 
			{ "Astronomy",      "  O ○ (Astronomica) ○ O  " }, // Astronomy - Predict the weather and much more.
			{ "Botany",         "  ☼~§~╢ Botanica ╠═╤╧═( )" }, // Botany - Study and breed plants for whichever purposes you choose
			{ "Ecology",        "  (▲▼≈= Ecologica ▲▼≈=)  " }, // Ecology - Assessing and setting policy for natural resources, to include hunting, foraging, farming, geology
			{ "Economy",        " ╠═O══╡ Œconomica ╞══O═╣ " }, // Economics - Assessing and setting policy for productive work and its products 
			{ "Statistics",     "  ╒═╛ Epomenologica ╒═╛  " }, // Statistics - Choose variables and see their correlations
			{ "Theology",       " ╠╪O╪╣ Theologica  ╠╪O╪╣ " }, // Theology - Figure out the bizarre dynamics of the ProcGen Pantheon
			{ "Rituals",        "  «««  Telethurgica  »»» " }, // Ritecraft - Construct Rituals to make Peasants take their medicine
		};
		public static Dictionary<BookButtons, string[]> bookFiligreeTest = new Dictionary<BookButtons, string[]>()
		{
			{ BookButtons.Template, new string[] {		"123456789012345678901234567890123456789001234567",
														"    5   10   15   20   25   30   35   40   45 47",
														"    ↓    ↓    ↓    ↓    ↓    ↓    ↓    ↓    ↓  ↓"} }, // Template - Design book spines here
			{ BookButtons.Alchemy, new string[] {		"             ╓┬═─═─═○═─═O═─═○═─═─═┬╖            ",
														"             │║ A L C H Æ M I C A ║│            ",
														"             ╙┴═─═─═○═─═O═─═○═─═─═┴╜            "} }, // Alchemy - Test disease samples, plants, minerals. Make things out of them.
			{ BookButtons.Genealogy, new string[] {		"  |                                          |  ",
														"  |                Genealogica               |  ",
														"  |                                          |  "} }, // Genealogy - Analyze the occurrence of genetic traits in villagers to avoid mishaps.
			{ BookButtons.Zymology, new string[] {		"             ╒═╤═╤══════─~~~~─═╤═╕              ",
														"             ╘╤╧╤╛ Zymologica ╒╧╤╧╕             ",
														"              ╘═╧═─~~~~─══════╧═╧═╛             "} }, // Brewery - Make beer, wine, or whatever the fuck they drink in your world!
		};
		// Obv these need to be more minimalist. I'm just having fun, okay? >:(

		public BookButtonTheme(BookButtons book)
		{
			title = book;
		}

		public override void UpdateAndDraw(ControlBase control, TimeSpan time)
		{
			if (!(control is Button button) || !button.IsDirty)
				return;

			RefreshTheme(control.ThemeColors, control);
			Cell appearance = GetStateAppearance(control.State);

			int middle = (button.Height != 1 ? button.Height / 2 : 0);

			// Redraw the control
			button.Surface.Fill(
				appearance.Foreground,
				appearance.Background,
				appearance.Glyph, null);

			string[] filigree = bookFiligreeTest[BookButtons.Genealogy];

			button.Surface.Print(0, 0, filigree[0].Align(button.TextAlignment, button.Width));
			button.Surface.Print(0, 1, filigree[1].Align(button.TextAlignment, button.Width));
			button.Surface.Print(0, 2, filigree[2].Align(button.TextAlignment, button.Width));

			// These will not be resolved until the Bookshelf width bug is resolved

			button.IsDirty = false;
		}

		private void BookSpineGradient()
		{
			// Books have three Y-layers, that should be colored accordingly:
			// Top = Medium ; Middle = Lightest; Bottom = Darkest
		}
	}
}
