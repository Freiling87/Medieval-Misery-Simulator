using System;
using System.Collections.Generic;
using System.Text;

using MMS.Engine;

namespace MMS.Spatial
{
	public class WorldMap
	{
		public int width;
		public int height;

		public int humidityClimate;
		public int temperatureClimate;

		public List<MapTile> mapTiles = new List<MapTile>();

		public WorldMap(int _width, int _height)
		{
			humidityClimate = Program.Random.Next(1, 10);
			temperatureClimate = Program.Random.Next(1, 10);

			width = _width;
			height = _height;
		}

		public void GenerateMap()
		{
			for (int x = 0; x < width; x++)
				for (int y = 0; y < height; y++)
					mapTiles.Add(new MapTile(x, y));
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