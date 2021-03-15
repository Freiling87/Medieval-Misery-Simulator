using SadConsoleGame.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace SadConsoleGame.Map
{
	class Agent : PhysObject
	{
		int charity;
		int chastity;
		int diligence;
		int humility;
		int kindness;
		int patience;
		int temperance;

		int choler;
		int melancholy;
		int phlegmatism;
		int sanguinity;

		string sex = null;
		int dateBorn;
		int dateDied;

		public Agent(Place location, Agent father, Agent mother, Agent master, int dateBorn) : base(location)
		{
			if (Dice.PercentChance(50))
				sex = "Female";
			else
				sex = "Male";
			// Don't @ me

			charity = (father.charity + mother.charity) / 2;
			chastity = (father.chastity + mother.chastity) / 2;
			diligence = (father.diligence + mother.diligence) / 2;
			humility = (father.humility + mother.humility) / 2;
			kindness = (father.kindness + mother.kindness) / 2;
			patience = (father.patience + mother.patience) / 2;
			temperance = (father.temperance + mother.temperance) / 2;

			choler = (father.choler + mother.choler) / 2;
			melancholy = (father.melancholy + mother.melancholy) / 2;
			phlegmatism = (father.phlegmatism + mother.phlegmatism) / 2;
			sanguinity = (father.sanguinity + mother.sanguinity) / 2;
		}

		protected static int DoLabor(Place location, PhysObject target, Tool tool)
		{
			int result = 1;

			//

			return result;
		}

		protected override void Destroy()
		{
			// Code here

			base.Destroy();
		}
	}
}
