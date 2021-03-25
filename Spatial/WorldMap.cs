using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Spatial
{
	public class WorldMap
	{
		public static int width;
		public static int height;

		public static int humidityClimate;
		public static int temperatureClimate;

		public List<MapTile> mapTiles;

		public WorldMap(int _width, int _height)
		{
			width = _width;
			height = _height;

			for (int x = 0; x < _width; x++)
			{
				for (int y = 0; y < _height; x++)
				{
					mapTiles.Add(new MapTile(x, y));
				}
			}


		}

		public MapTile GetMapTile(int x, int y)
		{
			foreach (MapTile mapTile in mapTiles)
			{
				if (mapTile.x == x && mapTile.y == y)
					return mapTile;
			}
			return null;
		}
	}
}