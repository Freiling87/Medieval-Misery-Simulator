using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Resolutions
{
	class Dice
	{
		static Random random = new Random();

		public static bool PercentChance(int percentChance)
		{
			// TODO: Log out of range entries
			return random.Next(101) > percentChance;
		}
		public static bool PercentChance(float percentChance)
		{
			// TODO: Log out of range entries
			return random.Next(101) > percentChance;
		}
	}
}
