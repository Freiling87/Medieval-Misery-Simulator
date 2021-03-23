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
		// - I think Facts should be part of this, but with multiple parents. 
		//		- They might be relevant to multiple contexts. 
		//		- Knowing all Child facts, or a list of requirements that those facts fulfill, leads to the discovery of a parent Fact.
		//			- In this example, the Parent Fact is the cure for a disease. The Child facts are the ingredients and the origins of those ingredients.
		//				- For this reason, you may need a special set of Unchanging Facts that fit into this structure.
		//					- Bruh, that's just called programming.
		//						- No, I mean In-World Unchanging Facts. The fact that you need wood for a simple wooden structure should be a part of this memeplex, as a ligament of sorts between the various procgen systems.
		//							- So in that case, you will neeed to matrix every Fact-creating class and ensure that there are ligament facts that will always be true, some of which the Player Character will know automatically. These should be unsurprising to the Player.
		//								- But to keep splitting hairs until I cause a fission reaction, a Unchanging Fact is an opportunity to further introduce modularity, emergence, and variation. What would a world without Wood look like? What would be the next best thing to build a shack or a tool handle out of? What qualities go into Wood being a good thing for those purposes? Identify those variables, and the content of that Unchanging Fact could be modular.
		//		
		// So here's the plan:
		//	Create species of facts, with basic relationships in node trees
		//		Identify patterns of relationships, where the species of node is part of that pattern
		//			I mean, literally iterate through every node, formalize various scopes of its relationship tree into a pattern, and compare those. You might find patterns below facts as well as above them.
		//	Example Fact Species: "Tendency" - identical to a WHERE in SQL, identify all members of a class with a particular criterion.
		//		Now, where do we find Tendencies of Tendencies?
		// If done right, this could lead villagers into surprising pattern identifications; If all wood in this World happens to be nonflammable, they may decide to burn fungi for fire.


		// https://en.wikipedia.org/wiki/Dual-phase_evolution
		// https://en.wikipedia.org/wiki/Memetic_algorithm
	}
}
