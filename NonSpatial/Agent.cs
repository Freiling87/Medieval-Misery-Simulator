using MMS.Resolutions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class Agent : PhysObject
	{
		int dateBorn;
		int dateDied;

		public Genome genome;

		string sex = null;
		string gender = null;
		int kinsey;

		int choler;
		int melancholy;
		int phlegmatism;
		int sanguinity;

		int charity;
		int chastity;
		int diligence;
		int humility;
		int kindness;
		int patience;
		int temperance;


		public Agent(Place location, Agent father, Agent mother, Agent master, int dateBorn) : base(location)
		{
			genome = Genome.Combination(father, mother);

			// Derive everything from above

		}
		public Agent(Place location, int dateBorn) : base(location)
		{
			genome = new Genome();
		}

		private void DeriveTraitsFromGenome()
		{

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
