using System;
using System.Collections.Generic;
using System.Text;
using MMS;
using MMS.Engine;

namespace MMS.NonSpatial
{
	class Gene
	{
		public Element element;
		public int valence;
		static int maxValence = 8;

		public Gene()
		{
			Array elements = Enum.GetValues(typeof(Elements));
			element = (Element)elements.GetValue(Program.Random.Next(elements.Length));

			valence = Program.Random.Next(maxValence + 1); 
		}
		public Gene(Element _element, int _valence)
		{
			element = _element;
			valence = _valence;
		}
	}
}
