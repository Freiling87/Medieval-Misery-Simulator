using MMS.Engine;
using MMS.NodeSystem;
using MMS.NonSpatial.PhysicalSystem;
using MMS.Resolutions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial.PhysicalSystem
{
	public class Agent : Entity
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

		//Place home;
		//Place location;
		// These are in PhysObject as well - not sure if they need to be mirrored here for access.

		public Agent(Place _location, Agent _father, Agent _mother, Agent _master, int dateBorn) : base(_location)
		{
			genome = Genome.Combination(_father.genome, _mother.genome);
			SetHome(_mother.GetHome());

		}
		public Agent(Place _location, int dateBorn) : base(_location)
		{
			genome = new Genome(); // Random
		}

		public Place GetHome() =>
			(Place)GetNodeOfRelationship(RelationshipType.home);
		public override void SetHome(Place home)
		{
			base.SetHome(home);
		}

		protected static int DoLabor(Place location, PhysObject target, Tool tool)
		{
			int result = 1;

			//

			return result;
		}

		public override void Destroy()
		{
			// Code here

			base.Destroy();
		}
	}
}
