using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NodeSystem
{
	public enum RelationshipType
	{
		// Agents
		father,
		mother,

		child,
		sibling,
		cousin, 
		auntUncle,
		neiceNephew,
		grandchild,
		grandparent,

		master,
		servant,

		// Places
		location,
		subLocation,

		home,

		// Objects
		madeOf, 
		comprises, // Need a converse relationship to MadeOf

	}

	public abstract class Node
	{
		//public List<Tuple<INode, string>> relationships = new List<Tuple<INode, string>>();
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

		// BASIC CHECKLIST OF MECHANICS IN AN ONTOLOGY:
		// https://en.wikipedia.org/wiki/Ontology_components

		private Dictionary<Node, List<RelationshipType>> connections = new Dictionary<Node, List<RelationshipType>>();
		public static List<RelationshipType> MonoRelationships = new List<RelationshipType>(); // Identify all relationships which may only have one connection.
		public static Guid UID = new Guid();

		public void AddRelationship(Node targetNode, RelationshipType isOfMe)
		{
			// TODO: Verify if a singular relationship is already taken, such as father/mother or Home

			if (MonoRelationships.Contains(isOfMe) && GetNodeOfRelationship(isOfMe) != null)
			{
				// Monorelationship already exists
				return;
			}

			if (connections.ContainsKey(targetNode))
			{
				if (connections[targetNode].Contains(isOfMe))
				{
					// Redundant addition
				}
				else
					connections[targetNode].Add(isOfMe);
			}
			else
				connections.Add(targetNode, new List<RelationshipType> { isOfMe });
		}
		public void AddRelationships(Node targetNode, RelationshipType[] isOfMe)
		{
			foreach (RelationshipType relationship in isOfMe)
				AddRelationship(targetNode, relationship);
		}

		public bool DoesRelationshipExist(Node targetNode, RelationshipType relationshipType)
		{
			foreach (RelationshipType connection in connections[targetNode])
				if (connection == relationshipType)
					return true;

			return false;
		}

		public List<RelationshipType> GetRelationshipTypes(Node targetNode) =>
			connections[targetNode];
		public Node GetNodeOfRelationship(RelationshipType relationshipType)
		{
			foreach (Node node in connections.Keys)
				if (connections[node].Contains(relationshipType))
					return node;

			return null;
		}
		public List<Node> GetDirectConnections(RelationshipType relationshipType)
		{
			List<Node> results = new List<Node>();

			foreach (Node node in connections.Keys)
				if (connections[node].Contains(relationshipType))
					results.Add(node);

			return results;
		}
		public Node GetLocation() =>
			GetDirectConnections(RelationshipType.location)[0];
		public Node GetRootOfType(Type type)
		{
			Node context = this;

			while (!(context.GetType() == type))
				context = context.GetLocation();

			return context;
		}

		public void RemoveRelationship(Node targetNode, RelationshipType isOfMe)
		{
			connections[targetNode].Remove(isOfMe);

			if (connections[targetNode].Count == 0)
				connections.Remove(targetNode);
		}
		public void RemoveAllRelationshipsOfType(RelationshipType isOfMe)
		{
			foreach (Node node in connections.Keys)
				foreach (RelationshipType relationship in connections[node])
					if (relationship == isOfMe)
						RemoveRelationship(node, isOfMe);
		}
	}
}
