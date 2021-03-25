using MMS.Engine;
using MMS.NodeSystem;
using MMS.NonSpatial.PhysicalSystem;
using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMS.NonSpatial
{
	public enum Seasons
	{
		winter,
		spring,
		summer,
		autumn
	}

	public class World : Node
	{
		Seasons currentSeason;

		public WorldMap worldMap { get; set; }

		public List<PhysObject> objects = new List<PhysObject>();

		public List<Entity> entities() =>
			objects.OfType<Entity>().ToList();
		public List<Fauna> fauna() =>
			entities().OfType<Fauna>().ToList();
		public List<Flora> flora() =>
			entities().OfType<Flora>().ToList();

		public World(bool DemoVersion)
		{
			if (DemoVersion)
			{
				currentSeason = Seasons.spring;
				WorldMap WorldMap = new WorldMap(10, 10);
			}
		}
	}
}