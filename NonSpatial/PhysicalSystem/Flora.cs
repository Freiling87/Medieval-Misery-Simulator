using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public enum FloraType
	{
		fungus,
		grass,
		mold,
		tree,
	}

	public class Flora : NonHumanObject
	{
		// Fuel, Feed, Fiber, and Reclamation

		public Genome genome;

		public Flora(Place location) : base(location)
		{

		}

		private string GenerateName()
		{
			string name = "";



			return name;
		}
	}
}
