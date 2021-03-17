using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.UI.Wiki
{
	class WikiCategory
	{
		WikiCategory parent;
		WikiPage page;

		public WikiCategory(string name, WikiCategory parent)
		{
			// Automatically create page when instantiated
			page = (WikiPage)Activator.CreateInstance(null, name, name.ToUpper());

		}
	}
}
