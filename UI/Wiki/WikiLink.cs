using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.UI.Wiki
{
	public enum WikiLinkTypes
	{
		Normal,
		Uncertain,
		Certain,
		Broken
	}

	class WikiLink
	{
		static int startIndex;
		static int length;
		static string destination;
		static string textColor;
		static string bgColor;
		public string linkText;

		public WikiLink(int startIndex, int length, string entryType, string destination, string displayText)
		{
			linkText = FormattedHyperLinkText(displayText);
		}

		private string FormattedHyperLinkText(string input)
		{
			StringBuilder output = new StringBuilder();
			WikiLinkTypes linkType = DetermineLinkType(destination);

			switch (linkType)
			{
				case WikiLinkTypes.Normal:
					textColor = "blue";
					bgColor = null;
					break;
				case WikiLinkTypes.Certain:
					textColor = "green";
					bgColor = null;
					break;
				case WikiLinkTypes.Uncertain:
					textColor = "orange";
					bgColor = null;
					break;
				case WikiLinkTypes.Broken:
					textColor = "red";
					bgColor = null;
					break;
			}

			output.Append("[c:r");

			if (!string.IsNullOrEmpty(textColor))
				output.Append(" f:" + textColor); // TODO: You might end up with two end brackets this way, split it out

			if (!string.IsNullOrEmpty(bgColor))
				output.Append(" b:" + bgColor); // TODO: You might end up with two end brackets this way, split it out

			output.Append("]");

			output.Append(input + "[c:undo]");

			return output.ToString();
		}

		private WikiLinkTypes DetermineLinkType(string destination)
		{
			// Determine what sort of hyperlink should be generated based on player's knowledge of the subject

			return WikiLinkTypes.Normal;
		}
	}
}
