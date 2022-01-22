using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Microsoft.Xna.Framework;

using MMS.Engine;
using SadConsole;
using SadConsole.Controls;
using SadConsole.Themes;

using Color = Microsoft.Xna.Framework.Color;

namespace MMS.UI.Themes
{
	public enum BookButtonTitles
	{
		Alchemy,
		Astronomy,
		Botany,
		Ecology,
		Economy,
		Encyclopedia,
		Genealogy,
		Statistics,
		Theology,
		Rituals,
		Zymology,
		Blank,
		Align,
	}
	
	class BookButtonTheme : ButtonTheme
	{
		public BookButtonTheme()
		{
		}

		public static Dictionary<BookButtonTitles, string[]> bookFiligrees = new Dictionary<BookButtonTitles, string[]>()
		{
			{ BookButtonTitles.Blank, new string[] {        KnownColor.Blue.ToString(), // Book Color
															Color.White.ToString(), // Filigree Color
															"                                                ",
															"                                                ",
															"                                                "} }, // Template - Blank for copying
			{ BookButtonTitles.Align, new string[] {        Color.Black.ToString(),
															Color.White.ToString(),
															"123456789012345678901234567890123456789001234567",
															"    5   10   15   20   25   30   35   40   45 47",
															"    ↓    ↓    ↓    ↓    ↓    ↓    ↓    ↓    ↓  ↓"} }, // Aligner - Use to ensure symmetry when needed
			{ BookButtonTitles.Alchemy, new string[] {      KnownColor.DarkRed.ToString(),
															KnownColor.DarkGoldenrod.ToString(),
															" │█                                          █│ ",
															" │█           A L - C H Æ M I Q Q A          █│ ",
															" │█                                          █│ "} }, // Alchemy - Test disease samples, plants, minerals. Make things out of them.
			{ BookButtonTitles.Astronomy, new string[] {    KnownColor.DarkSlateGray.ToString(),
															KnownColor.LightGoldenrodYellow.ToString(),
															"                •       •       •               ",
															"           •     ( Astronomica )     •          ",
															"                •       •       •               "} }, // Astronomy - Predict the weather and much more.
			{ BookButtonTitles.Botany, new string[] {       KnownColor.RosyBrown.ToString(),
															KnownColor.LightGoldenrodYellow.ToString(),
															"           ┌─┬~~~~~☼  { ☼ }  ☼~~~~~┐ ⌠☼         ",
															"         ☼~┤ │   B o t a n i c a   │ ├~☼        ",
															"          ☼⌡ ╘═════════════════════╧═╛          "} }, // Botany - Study and breed plants for whichever purposes you choose
			{ BookButtonTitles.Ecology, new string[] {      KnownColor.Green.ToString(),
															KnownColor.White.ToString(),
															"                                                ",
															"                    Ecologica                   ",
															"                                                "} }, // Ecology - Assessing and setting policy for natural resources, to include hunting, foraging, farming, geology
			{ BookButtonTitles.Economy, new string[] {      KnownColor.Gold.ToString(),
															KnownColor.Purple.ToString(),
															"                                                ",
															"   ╠═O══╡           Oeconomia          ╞══O═╣   ",
															"                                                "} }, // Economics - Assessing and setting policy for productive work and its products
			{ BookButtonTitles.Encyclopedia, new string[] { KnownColor.DarkGoldenrod.ToString(),
															KnownColor.DarkSlateGray.ToString(),
															"                                                ",
															" •             ~< Encyclopædia >~             • ",
															"                                                "} }, // Encyclopedia - Articles about all things known. 
			{ BookButtonTitles.Genealogy, new string[] {    KnownColor.DarkSlateGray.ToString(),
															KnownColor.Silver.ToString(),
															" ╟╢ ┌─────────────┐                       ◘ ╟╢  ",
															" ╟╢ │ Genealogica │                       ◘ ╟╢  ",
															" ╟╢ └─────────────┘                       ◘ ╟╢  "} }, // Genealogy - Analyze the occurrence of genetic traits in villagers to avoid mishaps.
			{ BookButtonTitles.Statistics, new string[] {   KnownColor.DarkGreen.ToString(),
															KnownColor.PaleGoldenrod.ToString(),
															"   ⌠                                        ⌠   ",
															"   │             • Epomenologica •          │   ",
															"   ⌡                                        ⌡   "} }, // Statistics - Choose variables and see their correlations
			{ BookButtonTitles.Theology, new string[] {     KnownColor.DeepSkyBlue.ToString(),
															KnownColor.LightGoldenrodYellow.ToString(),
															"   ╓┬┬┬┬┐▼┌┬┬┬┬╥────────────────╥┬┬┬┬┐▼┌┬┬┬┬╖   ",
															" • ╠╪╪╪╪╡☼╞╪╪╪╪╣   Theologica   ╠╪╪╪╪╡☼╞╪╪╪╪╣ • ",
															"   ╙┴┴┴┴┘▲└┴┴┴┴╨────────────────╨┴┴┴┴┘▲└┴┴┴┴╜   "} }, // Theology - Figure out the bizarre dynamics of the ProcGen Pantheon
			{ BookButtonTitles.Rituals, new string[] {      KnownColor.Orange.ToString(),
															KnownColor.Black.ToString(),
															"                                                ",
															"             «««  Telethurgica  »»»             ",
															"                                                "} }, // Ritecraft - Construct Rituals to make Peasants take their medicine
			{ BookButtonTitles.Zymology, new string[] {     KnownColor.Brown.ToString(),
															KnownColor.Silver.ToString(),
															"             ╒═╤═╤══════─~~~~─═╤═╕              ",
															"             ╘╤╧╤╛ Zymologica ╒╧╤╧╕             ",
															"              ╘═╧═─~~~~─══════╧═╧═╛             "} }, // Brewery - Make beer, wine, or whatever the fuck they drink in your world!
		};

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
				appearance.Glyph, 
				null);

			// Draw Filigrees
			int nonFiligreeValueSkip = 2;
			BookButtonTitles spine = Enum.Parse<BookButtonTitles>(button.Text);
			string[] filigree = bookFiligrees[spine];

			Color fColorB = XNAColor(System.Drawing.Color.FromKnownColor(Enum.Parse<KnownColor>(filigree[1])));
			Color fColorA = ColorShiftTorchlight(fColorB);
			Color fColorC = ColorShiftShadow(fColorB);

			List<Color> fColors = new List<Color> { fColorA, fColorB, fColorC };

			Color bgColorB = XNAColor(System.Drawing.Color.FromKnownColor(Enum.Parse<KnownColor>(filigree[0])));
			Color bgColorA = ColorShiftTorchlight(bgColorB);
			Color bgColorC = ColorShiftShadow(bgColorB);

			List<Color> bgColors = new List<Color> { bgColorA, bgColorB, bgColorC};

			for (int i = nonFiligreeValueSkip; i < 3 + nonFiligreeValueSkip; i++)
				button.Surface.Print(0, i - nonFiligreeValueSkip, filigree[i].ToAscii().Align(button.TextAlignment, button.Width), fColors[i - nonFiligreeValueSkip], bgColors[i - nonFiligreeValueSkip]);

			button.IsDirty = false;
		}

		public Color XNAColor(System.Drawing.Color color) =>
			new Color(color.R, color.G, color.B, color.A);

		public Color ColorShiftTorchlight(Color color)
		{
			color.B = (byte)Math.Clamp(color.B * 0.90f, 0, 255);
			color.G = (byte)Math.Clamp(color.G * 1.05f, 0, 255);
			color.R = (byte)Math.Clamp(color.R * 1.10f, 0, 255);
			
			return color;
		}

		public Color ColorShiftShadow(Color color)
		{
			color.B = (byte)Math.Clamp(color.B * 1.10f, 0, 255);
			color.G = (byte)Math.Clamp(color.G * 0.95f, 0, 255);
			color.R = (byte)Math.Clamp(color.R * 0.90f, 0, 255);

			return color;
		}

		private void BookSpineGradient()
		{

		}
	}
}
