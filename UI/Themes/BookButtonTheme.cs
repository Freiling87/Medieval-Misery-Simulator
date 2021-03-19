using System;
using System.Collections.Generic;
using System.Text;

using SadConsole;
using SadConsole.Controls;
using SadConsole.Themes;

namespace MMS.UI.Themes
{
	public enum BookButtonEnum
	{
		Alchemy,
		Town,
		Genealogy,
		Zymology
	}
	
	class BookButtonTheme : ButtonTheme
	{
		private static BookButtonEnum title;

		public static Dictionary<BookButtonEnum, string[]> bookFiligreeTest = new Dictionary<BookButtonEnum, string[]>()
		{
			{ BookButtonEnum.Town, new string[] {		"   a                    a  ",
														"          EXAMPLE          ",
														"   a                   a   "} }, // Template - Design book spines here
			{ BookButtonEnum.Alchemy, new string[] {    "  ╓┬═─═─═○═─═O═─═○═─═─═┬╖  ",
														"  │║ A L C H Æ M I C A ║│  ",
														"  ╙┴═─═─═○═─═O═─═○═─═─═┴╜  "} }, // Template - Design book spines here
			{ BookButtonEnum.Genealogy, new string[] {	"  ║               ═OOO  ║  ",
														"  ║ ○  Genealogica └┼┘  ║  ",
														"  ║                O╧O  ║  "} }, // Template - Design book spines here
			{ BookButtonEnum.Zymology, new string[] {   "   ╒═╤═╤══════─~~~~─═╤═╕   ",
														"   ╘╤╧╤╛ Zymologica ╒╧╤╧╕  ",
														"    ╘═╧═─~~~~─══════╧═╧═╛  "} }, // Brewery - Make beer, wine, or whatever the fuck they drink in your world!
		};
		// Obv these need to be more minimalist. I'm just having fun, okay? >:(

		public BookButtonTheme(BookButtonEnum book)
		{
			title = book;

			ShowEnds = false;

			switch (title)
			{
				case BookButtonEnum.Town:
					break;
				default:

					break;
			}
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

			string[] filigree = bookFiligreeTest[BookButtonEnum.Alchemy];

			//button.Surface.Print(0, 0, filigree[0].Align(button.TextAlignment, button.Width));
			//button.Surface.Print(0, 1, filigree[1].Align(button.TextAlignment, button.Width));
			//button.Surface.Print(0, 2, filigree[2].Align(button.TextAlignment, button.Width));

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
