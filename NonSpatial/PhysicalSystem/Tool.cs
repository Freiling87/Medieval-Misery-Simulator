using MMS.NodeSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NonSpatial
{
	public class Tool : NonHumanObject
	{
		// On the distinction between Owner, User, and Master:
		//		Master may be an elegant way to serve as Owner. This is because an Agent's Masters want to command not only the Agent, but his tools too.
		//			But then, how are Tools differentiated from Employees? Is it safe to have both types in the same node tree?
		//			Also, when can you use your master's tools? Your employee's?

		public float durability;

		public Tool (Place place) : base(place)
		{

		}
	}
}
