using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	class Place
	{
		// Node-based, to differentiate different farm plots on the same map tile. Policy would indicate whether plots are shared or not.
		// These are NOT map tiles. 

		MapTile mapTile = null;
		Place parent = null;
		Place[] children = null;

		Place(MapTile location, Place MyParent, Place[] myChildren)
		{
			parent = MyParent;
			children = myChildren;
		}

		private string GenerateName()
		{
			string name = "placeholder name";


			return name;
		}
	}
}
