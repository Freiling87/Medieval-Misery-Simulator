using System;
using System.Collections.Generic;
using System.Text;

namespace SadConsoleGame.Noun
{
	class Place : Noun
	{
		// Node-based, to differentiate different farm plots on the same map tile. Policy would indicate whether plots are shared or not.

		Place parent = null;
		Place[] children = null;

		Place(Place MyParent, Place[] myChildren)
		{
			parent = MyParent;
			children = myChildren;
		}

		private string GenerateName()
		{
			string name = "placeholder name";


			return name;
		}
	}
}
