﻿using MMS.NonSpatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Spatial
{
	class MapTile
	{
		public int humidity;
		public int temperature;
		public List<WeatherEvent> weatherEvents;
		public List<Place> places; // Need abstract parent-level Place

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