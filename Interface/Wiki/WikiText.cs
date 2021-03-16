using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Interface.Wiki
{
	class WikiText
	{
		// Output text will have [c:r f:yellow]links[c:undo] syntax readable by SadConsole
		// Output object will store HyperLink objects within it that tell it where to place links within said text and where they go.
		// The coordinates of where to place the links should not be done yet - that will depend on the window that houses the text and its character wrap.

		public WikiText (string inputText)
		{
			// IN: "Hey {Person:James Johnson|Jimmy}, how ya doing?"
			// OUT: WikiText Object with WikiLink objects attached each of which has:
			//		Text: "Hey [c:r f:red b:blue]Jimmy[c:undo], how ya doing?"
			//		index of link = 4
			//		length of link = 5
			//		destination of link = "James Johnson"

			List<WikiLink> links = new List<WikiLink>();

			while (inputText.IndexOf('{') != -1)
			{
				// E.g.: {People:James Johnson|Jimmy}

				string linkText = DelineatedSubstring(inputText, '{', '}');

				int linkStart = inputText.IndexOf('{');
				int linkLength = (inputText.IndexOf('}') - linkStart) + 1;
				inputText.Remove(linkStart, linkLength);

				string type = DelineatedSubstring(linkText, '{', ':');
				string destination = DelineatedSubstring(linkText, ':', '|');
				string displayText = DelineatedSubstring(linkText, '|', '}');

				WikiLink hyperLink = new WikiLink(linkStart, linkLength, type, destination, displayText);

				links.Add(hyperLink);

				inputText.Replace(linkText, hyperLink.linkText);
			}
		}

		private string DelineatedSubstring(string input, char start, char end)
		{
			int startIndex = input.IndexOf(start);
			int length = input.IndexOf(end) - startIndex + 1;

			return input.Substring(startIndex, length);
		}
	}
}
