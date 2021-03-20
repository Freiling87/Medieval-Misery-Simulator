using MMS.Spatial;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class PhysObject
	{
		private Place place;

		public PhysObject(Place location)
		{

		}

		protected void Move(Place newPlace)
		{
			place = newPlace;
		} 
		protected void Move(MapTile newLocation)
		{
			place = newLocation.places[0];
		}

		protected virtual void Destroy()
		{

		}

	}
}
