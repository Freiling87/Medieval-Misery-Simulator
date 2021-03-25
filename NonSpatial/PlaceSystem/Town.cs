using MMS.NodeSystem;
using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class Town : Place
	{

		public Town(Place _location) : base(_location)
		{

		}
		public Town(MapTile _location) : base(_location)
		{

		}
	}
}
