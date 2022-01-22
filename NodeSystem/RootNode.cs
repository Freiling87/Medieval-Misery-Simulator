using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.NodeSystem
{
	class RootNode : Node
	{
		// You're probably wondering:, is there a need for a Singleton class to serve as the root node?
		//		What exactly would make that preferable to simply expecting a null, you ask? Isn't using and handling null the elegant solution here?
		//			First, get that Pythonic shit out of here.
		//				Expecting a null might lead to unexpected behaviors if you *ever* forget to declare a parent node.
		//				In the no-root idea, the use of null relies on an *implied* intent of null rather than the explicit intent of a root node.
		//		Therefore, I believe there needs to be an empty Root Node class, as a way of raising a red flag when parent is unexpectedly null.
		// This will indicate to node traversals that if they encounter a RootNode when they shouldn't, they'll have alternate behaviors.
		// So anything that can nest inside a location, as well as this singleton, should inherit INodeable.
		// E.g., let's consider Lineage in Agents, versus Nesting in Places. Both node trees. 
		// INodeable should be content-agnostic; therefore, you'll need methods within Place or Agent specific to the IRL logic of node traversal in that context.
		//		a Place doesn't need to know if another Place is its second cousin but an Agent will. 
		//		And I'm sure there are examples in reverse.
	}
}