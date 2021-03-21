using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class PhysObject
	{
		public Agent holder; // Who gets use of the tool for the day.
		public Agent master; // Master's tools are usable by anyone below them. They may still have their own tools he cannot access..

		public Place home;
		public Place location;

		public PhysObject(Place location)
		{

		}

		protected void MoveHome(Place newPlace)
		{
			home = newPlace;
		}

		protected void MoveLocation(Place newPlace)
		{
			location = newPlace;
		} 
		protected void MoveLocation(MapTile newMapTile)
		{
			location = newMapTile.places[0];
		}

		protected virtual void Destroy()
		{

		}
	}
}