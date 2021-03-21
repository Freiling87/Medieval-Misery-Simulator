using MMS.Engine;
using MMS.NodeSystem;
using MMS.Resolutions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class Agent : PhysObject, INode
	{
		Agent father;
		Agent mother;
		Agent master;


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

		//Place home;
		//Place location;
		// These are in PhysObject as well - not sure if they need to be mirrored here for access.

		public Agent(Place _location, Agent _father, Agent _mother, Agent _master, int dateBorn) : base(_location)
		{
			genome = Genome.Combination(_father, _mother);
			location = _location;
			father = _father;
			mother = _mother;

			home = mother.home;

			// Derive everything from above
		}
		public Agent(Place _location, int dateBorn) : base(_location)
		{
			genome = new Genome();
			location = _location;
			home = mother.home;
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
