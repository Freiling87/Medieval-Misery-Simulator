using System;
using System.Collections.Generic;
using System.Text;

using MMS.NodeSystem;

namespace MMS.UI.Wiki
{
	public class WikiText
	{
		public string plaintext;

		public WikiText (string inputText)
		{
			// IN: "Hey {Person:James Johnson|Jimmy}, how ya doing?"
			// OUT: WikiText Object with WikiLink objects attached each of which has:
			//		Text: "Hey [c:r f:red b:blue]Jimmy[c:undo], how ya doing?"


			// TODO: Create UIDs for Wikiable objects, and pass {UID} for easy linking

			List<WikiLink> links = new List<WikiLink>();

			while (inputText.IndexOf('{') != -1)
			{
				string linkText = DelineatedSubstring(inputText, '{', '}', false);

				int linkStart = inputText.IndexOf('{');
				int linkLength = (inputText.IndexOf('}') - linkStart) + 1;

				string type = DelineatedSubstring(linkText, '{', ':', true);
				string destination = DelineatedSubstring(linkText, ':', '|', true);
				string displayText = DelineatedSubstring(linkText, '|', '}', true);

				WikiLink hyperLink = new WikiLink(linkStart, linkLength, type, destination, displayText);

				links.Add(hyperLink);
				inputText = inputText.Replace(linkText, hyperLink.linkText);
			}

			plaintext = inputText;
		}

		private string ProcessInputString(string inputText)
		{
			return inputText;
		}

		private string DelineatedSubstring(string input, char start, char end, bool trimDelineators)
		{
			int startIndex = input.IndexOf(start);
			int length = input.IndexOf(end) - startIndex + 1;

			if (trimDelineators)
				return input.Substring(startIndex + 1, length - 2);
			else
				return input.Substring(startIndex, length);
		}
	}
}
