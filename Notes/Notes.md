# Interface
## Wiki General

- A C# in-game wiki for RimWorld: https://github.com/Epicguru/InGameWiki

## Hyperlinks
- Per Thraka:
	1. An input component link manager. This object tracks the mouse. If the mouse is over a link, it restyles the link text. Clicking a link area triggers the link object's action.
	2. A link object which is added to the manager. The link object has (1) x,y or index for where the link starts (2) link length (3) link code action to trigger when clicked

## Navigator

Custom BookButton:Button class that will make the buttons look like books
	Appearances are consistent per button label
	Filigree lines crossing the spine of the book are drawn across all three levels of the gradient with | character or others
	Spine & title have gold (or other) filigrees
		Existing button label of	<         Alchemy        >
		Is turned into, for example:<8-=-=-=< Alchemy >-=-=-8>
			OR SOMETHING, obviously prettier ASCII style

# Fact System
- Per Redxaxder, this is for compressing bitfields. It could be a useful way to track which Facts are known: https://wolfgarbe.medium.com/elias-fano-quasi-succinct-compression-of-sorted-integers-in-c-89f92a8c9986