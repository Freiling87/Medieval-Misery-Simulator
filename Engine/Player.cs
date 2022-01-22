using System;
using System.Collections.Generic;
using System.Text;

using MMS.Engine;
using MMS.UI;
using MMS.UI.Screens;
using MMS.UI.Themes;

namespace MMS.Engine
{
	public class Player
	{
		// TODO: Have a joke control to try to travel, which is not a feature in this game, at least in concept so far.
		// If you're under 35, say "I don't have any PTO!"
		// If you're 35-55, say "I have too much to catch up on here, I don't even want to travel. I need to afford that house."
		// If you're over 55, say "I'm not healthy enough to travel!"
		// If you're over 75, end the game and show the image of Merlin in his vacation clothing, with Hawaiian music. This is The Good Ending. Log message, "Fuck it!"

		public List<BookButtonTitles> unlocksBookshelf;

		public Player()
		{
			unlocksBookshelf = new List<BookButtonTitles>() { };
			DebugUnlockAllButtons();
		}

		private void DebugUnlockAllButtons()
		{
			int titleCount = Enum.GetNames(typeof(BookButtonTitles)).Length;
			int excludedDebugTitles = 2;

			for (int i = 0; i < titleCount - excludedDebugTitles; i ++)
				unlocksBookshelf.Add((BookButtonTitles)i);
		}
	}
}
