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

		public MapTile(int _x, int _y)
		{
			AddRelationship(Program.World, RelationshipType.location);
			x = _x;
			y = _y;

			humidityClimate = Math.Clamp(World.WorldMap.humidityClimate + Program.Random.Next(-5, 5), 0, 10);
			temperatureClimate = Math.Clamp(World.WorldMap.temperatureClimate + Program.Random.Next(-5, 5), 0, 10);

			//UIManager.MessageLog.LogMessage("Created MapTile " + this + ": " + "Humidity = " + humidityClimate + "; Temperature = " + temperatureClimate);
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