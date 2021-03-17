using System;
using System.Collections.Generic;
using System.Text;

namespace MMS
{
	public class Player
	{
		public static List<string> unlocks;

		public Player()
		{
			unlocks = new List<string>() { };
			DebugUnlockAllButtons();
		}

		private void DebugUnlockAllButtons()
		{
			List<string> debugUnlockAll = new List<string>()
;
			unlocks.AddRange(new string[]{
				"Alchaemica",
				"Astronomica",
				"Botanica",
				"Telethurgica", // Ritecraft
				"Oenologica" 
			});
		}
	}
}
