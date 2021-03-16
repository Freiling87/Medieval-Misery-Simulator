using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Interface.Wiki
{
	class WikiPage
	{
		List<WikiText> wikiTexts;
		string name;
		string displayName;

		public WikiPage(string name, string displayName)
		{

		}
		private void GetHeaderImage()
		{

		}
		private void CreateHeader(string header, WikiText text)
		{
			if (name == "Root")
				displayName = "Root Placeholder title";
		}
		private void CreateSection(WikiText text)
		{

		}
		private void CreateFooter(WikiText text)
		{

		}
	}
}
