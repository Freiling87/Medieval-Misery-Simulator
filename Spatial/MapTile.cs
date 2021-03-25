using MMS.Engine;
using MMS.NodeSystem;
using MMS.NonSpatial;

using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Spatial
{
	public class MapTile : Node
	{
		public int x;
		public int y;

		public int humidityClimate;
		public int temperatureClimate;

		public int humidityCurrent;
		public int temperatureCurrent;
		public List<WeatherEvent> weatherEvents;
		public List<Place> places; 

		public MapTile(int mapX, int mapY)
		{
			AddRelationship(Program.World, RelationshipType.location);
		}

		public void SetWeather(int? newHumidity = null, int? newTemperature = null, WeatherEvent[]? newEvents = null)
		{
			if (newHumidity != null)
			{
				humidityCurrent = (int)newHumidity;
			}
			
			if (newTemperature != null)
			{
				temperatureCurrent = (int)newTemperature;
			}
			
			if (newEvents != null)
			{
			}
		}
		public void ResolveWeather()
		{

		}
	}
}