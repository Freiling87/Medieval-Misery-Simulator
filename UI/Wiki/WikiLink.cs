using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.UI.Wiki
{
	public enum WikiLinkType
	{
		Normal,
		Uncertain,
		Certain,
		Broken
	}

	public class WikiLink
	{
		public int startIndex;
		public int length;
		static string entryName;
		static string entryType;
		static string textColor;
		static string bgColor;
		public string displayText;
		public WikiLinkType linkType;

		public WikiLink(int _startIndex, int _length, string _entryType, string _entryName, string _displayText)
		{
			startIndex = _startIndex;
			length = _length;
			entryType = _entryType;
			entryName = _entryName;
			displayText = FormattedHyperLinkText(_displayText);
		}

		private string FormattedHyperLinkText(string input)
		{
			StringBuilder output = new StringBuilder();
			WikiLinkType linkType = DetermineLinkType(entryName);

			switch (linkType)
			{
				case WikiLinkType.Normal:
					textColor = "blue";
					bgColor = null;
					break;
				case WikiLinkType.Certain:
					textColor = "green";
					bgColor = null;
					break;
				case WikiLinkType.Uncertain:
					textColor = "orange";
					bgColor = null;
					break;
				case WikiLinkType.Broken:
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

		private WikiLinkType DetermineLinkType(string destination)
		{
			// Determine what sort of hyperlink should be generated based on player's knowledge of the subject

			return WikiLinkType.Normal;
		}
	}
}
