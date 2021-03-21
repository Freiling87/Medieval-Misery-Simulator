using MMS.NodeSystem;
using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class Place : INode
	{
		// Much like the real-world concept of Place, this is a non-physical and non-spatial entity. It may have to do some extra work to help communication between the Spatials & NonSpatials. 
		// Wait... does that mean this should be an abstract class?

		// Node-based, to differentiate different farm plots on the same map tile. Policy would indicate whether plots are shared or not.
		// These are NOT map tiles. 

		MapTile mapTile = null;
		Place parent = null;
		Place[] children = null;

		public List<Agent> residents; // Includes non-present villagers traveling elsewhere
		public List<Agent> occupants; // Includes anyone present, including travelers and animals

		// TODO: Create IAnimal interface to accept both in these lists.

		public Place(MapTile location, Place? parent, Place[]? children)
		{
			this.parent = parent;
			this.children = children;

			if (parent == null)
				location.places.Add(parent);
		}

		private string GenerateName()
		{
			string name = "placeholder name";


			return name;
		}
	}
}
