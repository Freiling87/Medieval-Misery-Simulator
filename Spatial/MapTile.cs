using MMS.NonSpatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Spatial
{
	public class MapTile
	{
		public int humidity;
		public int temperature;
		public List<WeatherEvent> weatherEvents;
		public List<Place> places; // MapTile is a Root node for the Location hierarchy.
		// This might be a place where you should create an Interface (ILocationNode) and implement it in MapTile, PhysObject and Place. Allow MapTile to be root Node in the non-spatial location system.
		// This 

		public MapTile(int mapX, int mapY)
		{
			// Need an abstract non-place to parent all places within the tile, so that no Place lacks a parent
			// Or alternatively, allow place to be null on objects and actors.
		}

		public void SetWeather(int? newHumidity = null, int? newTemperature = null, string[]? newEvents = null)
		{
			if (newHumidity != null)
			{
				//
				humidity = (int)newHumidity;
				//
			}
			
			if (newTemperature != null)
			{
				//
				temperature = (int)newTemperature;
				//
			}
			
			if (newEvents != null)
			{
				//
			}
		}
	}
}
