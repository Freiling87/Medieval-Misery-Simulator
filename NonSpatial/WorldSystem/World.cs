using MMS.Engine;
using MMS.NodeSystem;
using MMS.NonSpatial.PhysicalSystem;
using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMS.UI;
using MMS.UI.Screens;
using MMS.UI.Wiki;

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

		public static WorldMap WorldMap { get; set; }

		public List<PhysObject> objects = new List<PhysObject>();

		public List<Entity> Entities() =>
			objects.OfType<Entity>().ToList();
		public List<Fauna> Fauna() =>
			Entities().OfType<Fauna>().ToList();
		public List<Flora> Flora() =>
			Entities().OfType<Flora>().ToList();

		public World(bool DemoVersion)
		{
			UIManager.LogMessage("Here's a {Test:Test|Test} example string, and it's long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long long.");

			if (DemoVersion)
			{
				currentSeason = Seasons.spring;
				WorldMap = new WorldMap(10, 10);
			}
		}
	}
}