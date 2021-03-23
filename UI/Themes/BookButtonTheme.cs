using System;
using System.Collections.Generic;
using System.Text;
using MMS.Engine;
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
		TemplateBlank,
		TemplateAlign,
	}
	
	class BookButtonTheme : ButtonTheme
	{
		private static BookButtons title;

		public static Dictionary<string, string> deprecatedBookTitles = new Dictionary<string, string>()
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
		public static Dictionary<BookButtons, string[]> bookFiligrees = new Dictionary<BookButtons, string[]>()
		{
			{ BookButtons.TemplateBlank, new string[] { "                                                ",
														"                                                ",
														"                                                "} }, // Template - Blank for copying
			{ BookButtons.TemplateAlign, new string[] {	"123456789012345678901234567890123456789001234567",
														"    5   10   15   20   25   30   35   40   45 47",
														"    ↓    ↓    ↓    ↓    ↓    ↓    ↓    ↓    ↓  ↓"} }, // Aligner - Use to ensure symmetry when needed
			{ BookButtons.Alchemy, new string[] {		"             ╓┬═─═─═○═─═O═─═○═─═─═┬╖            ",
														"             │║ A L C H Æ M I C A ║│            ",
														"             ╙┴═─═─═○═─═O═─═○═─═─═┴╜            "} }, // Alchemy - Test disease samples, plants, minerals. Make things out of them.
			{ BookButtons.Astronomy, new string[] {		"                                                ",
														"                   Astronomica                  ",
														"                                                "} }, // Astronomy - Predict the weather and much more.
			{ BookButtons.Genealogy, new string[] {     "  ║                                          ║  ",
														"  ║                Genealogica               ║  ",
														"  ║                                          ║  "} }, // Genealogy - Analyze the occurrence of genetic traits in villagers to avoid mishaps.
			{ BookButtons.Zymology, new string[] {		"             ╒═╤═╤══════─~~~~─═╤═╕              ",
														"             ╘╤╧╤╛ Zymologica ╒╧╤╧╕             ",
														"              ╘═╧═─~~~~─══════╧═╧═╛             "} }, // Brewery - Make beer, wine, or whatever the fuck they drink in your world!
		};
		// Obv these need to be more minimalist. I'm just having fun, okay? >:(

		public BookButtonTheme(BookButtons book)
		{
			// TODO: Eliminate argument above and just pull it from the object rather than the call.

			title = book;
		}

		public override void UpdateAndDraw(ControlBase control, TimeSpan time)
		{
			if (!(control is Button button) || !button.IsDirty)
				return;

			RefreshTheme(control.ThemeColors, control);
			Cell appearance = GetStateAppearance(control.State);

			// Redraw the control
			button.Surface.Fill(
				appearance.Foreground,
				appearance.Background,
				appearance.Glyph, null);

			string[] filigree = bookFiligrees[BookButtons.Genealogy];

			for (int i = 0; i < 3; i++)
				button.Surface.Print(0, i, filigree[i].ToAscii().Align(button.TextAlignment, button.Width));

			button.IsDirty = false;
		}

		private void BookSpineGradient()
		{
			// Books have three Y-layers, that should be colored accordingly:
			// Top = Medium ; Middle = Lightest; Bottom = Darkest
		}
	}
}
