using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NodeSystem
{
	interface INode
	{
		// Classes that need to inherit this: anything that is a part of any node tree in the game.
		// - Anything with heritability.
		// - Anything that can exist in a Place.
		// - Anything with a Master, Home, or Location (redundant to the last two, but may not always be true). E.g., can a Tool have a Master? 
	}
}
