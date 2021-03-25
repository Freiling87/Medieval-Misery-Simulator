using MMS.NodeSystem;
using MMS.NonSpatial.PhysicalSystem;
using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class Place : Node
	{
		// Node-based, to differentiate different farm plots on the same map tile. Policy would indicate whether plots are shared or not.

		// Objects → Places → MapTiles → World (root)

		public List<Agent> residents; // Includes non-present villagers traveling elsewhere
		public List<Agent> occupants; // Includes anyone present, including travelers and animals

		// TODO: Create IAnimal interface to accept both in these lists.

		public Place(Place _parent)
		{

		}
		public Place(MapTile _parent)
		{

		}

		public void AddToLocation(Place _parent)
		{
			AddRelationship(_parent, RelationshipType.location);
			_parent.AddRelationship(this, RelationshipType.subLocation);
		}

		private string GenerateName()
		{
			string name = "placeholder name";


			return name;
		}
	}
}
