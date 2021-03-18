using System;
using System.Collections.Generic;
using System.Text;

using MMS.Engine;
using MMS.UI;
using MMS.UI.Screens;

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
			List<string> debugUnlockAll = new List<string>();

			//debugUnlockAll = UIManager.Navigator.buttonUnlocks;
		}
	}
}
