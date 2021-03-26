using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using MMS.Engine;
using MMS.UI.Wiki;
using SadConsole;
using SadConsole.Components;
using SadConsole.Controls;
using SadConsole.Input;

namespace MMS.UI.Screens
{
	public class MessageLog : Window
	{
        InputConsoleComponent InputConsoleComponent;

        private static readonly int _maxEntries = 10000;
        private readonly Queue<string> _entries;
        private readonly ScrollingConsole _console;
        private readonly ScrollBar _scrollBar;
        private int _scrollPosition;
        private int _windowBorder = 2;
		private MouseConsoleState mouseState;

		public MessageLog(int width, int height, string title) : base(width, height)
        {
            _entries = new Queue<string>();

            height -= _windowBorder;
            width -= _windowBorder;

            Title = title.Align(HorizontalAlignment.Center, Width);

            _console = new ScrollingConsole(width, _maxEntries)
            {
                Position = new Point(1, 1),
                ViewPort = new Rectangle(0, 0, width, height),
            };

            _scrollBar = new ScrollBar(Orientation.Vertical, height)
            {
                Position = new Point(width + 1, _console.Position.Y),
                IsEnabled = false
            };
            _scrollBar.ValueChanged += MessageScrollBar_ValueChanged;
            Add(_scrollBar);

            Children.Add(_console);
        }

        void MessageScrollBar_ValueChanged(object sender, EventArgs e) =>
            _console.ViewPort = new Rectangle( 0, _scrollBar.Value + _windowBorder, _console.Width, _console.ViewPort.Height);

        public override void Draw(TimeSpan drawTime) =>
            base.Draw(drawTime);

        public override void Update(TimeSpan time)
        {
            base.Update(time);

            // Scrollbar tracks current position of console
            if (_console.TimesShiftedUp != 0 |
                _console.Cursor.Position.Y >= _console.ViewPort.Height + _scrollPosition)
            {
                _scrollBar.IsEnabled = true;

                // Prevent scroll past buffer
                // Record amount scrolled to enable how far back bar can see
                if (_scrollPosition < _console.Height - _console.ViewPort.Height)
                    _scrollPosition += (_console.TimesShiftedUp != 0 ? _console.TimesShiftedUp : 1);

                _scrollBar.Maximum = _scrollPosition - _windowBorder;

                // Follow cursor since render area moves in event.
                _scrollBar.Value = _scrollPosition;
                _console.TimesShiftedUp = 0;
            }
        }

        public void LogMessage(string message)
        {
            WikiText wikiText = new WikiText(message);

            _entries.Enqueue(message);

            while (_entries.Count > _maxEntries)
                _entries.Dequeue();

            _console.Cursor.ResetAppearanceToConsole();
            _console.Cursor.Print(wikiText.plaintext);
            _console.Cursor.NewLine();

            // Per Thraka:
            // 1. An input component link manager. This object tracks the mouse. If the mouse is over a link, it restyles the link text. Clicking a link area triggers the link object's action.
            // 2.A link object which is added to the manager. The link object has(1) x,y or index for where the link starts(2) link length(3) link code action to trigger when clicked

            foreach (WikiLink link in wikiText.links)
			{
                Button wikiLink = new Button(link.length, 1)
                {
                    Position = link.startIndex.ToPoint(Width),
                };
			}
        }

        public void AddTextNoNewline(string text)
        {
            string[] lines = _entries.ToArray();
            lines[lines.Length] += text;
        }

    }
}
