using System;
using System.Collections.Generic;
using System.Text;

namespace SadConsoleGame.Noun
{
	class Agent : Noun
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

		public Agent(Agent father, Agent mother)
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

		public static int Action(Place location, Noun target, Tool tool)
		{
			

			return 1;
		}
	}
}
