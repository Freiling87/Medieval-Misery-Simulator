using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class Town : Place
	{

		public Town(MapTile location, Place parent, Place[]? children) : base(location, parent, children)
		{

		}
	}
}
