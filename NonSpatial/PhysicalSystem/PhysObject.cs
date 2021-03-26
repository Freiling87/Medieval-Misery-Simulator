using MMS.NodeSystem;
using MMS.NonSpatial.PhysicalSystem;
using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class PhysObject : Node
	{
		public PhysObject(Place _location)
		{
			AddRelationship(_location, RelationshipType.location);
		}

		public virtual void SetHome(Place newPlace)
		{
			RemoveAllRelationshipsOfType(RelationshipType.home);
			AddRelationship(newPlace, RelationshipType.home);
		}
		public virtual void SetLocation(Place newPlace)
		{
			RemoveRelationship(GetLocation(), RelationshipType.location);
			AddRelationship(newPlace, RelationshipType.location);
		} 

		public virtual void Destroy()
		{

		}
	}
}