using System;
using System.Collections.Generic;
using System.Text;


namespace MMS.Interface.Wiki
{
	public enum LinkType
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
			LinkType linkType = DetermineLinkType(destination);

			switch (linkType)
			{
				case LinkType.Normal:
					textColor = "blue";
					bgColor = null;
					break;
				case LinkType.Certain:
					textColor = "green";
					bgColor = null;
					break;
				case LinkType.Uncertain:
					textColor = "orange";
					bgColor = null;
					break;
				case LinkType.Broken:
					textColor = "red";
					bgColor = null;
					break;
			}

			output.Append("[c:r ");

			if (!string.IsNullOrEmpty(textColor))
				output.Append("f:" + textColor + "]");

			if (!string.IsNullOrEmpty(bgColor))
				output.Append("b:" + bgColor + "]");

			output.Append(input + "[c: undo]");

			return output.ToString();
		}

		private LinkType DetermineLinkType(string destination)
		{
			// Determine what sort of hyperlink should be generated based on player's knowledge of the subject

			return LinkType.Normal;
		}
	}
}
