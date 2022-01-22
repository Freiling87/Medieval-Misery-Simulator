using SadConsole.Components;
using SadConsole.Input;

namespace MMS.UI.Operations
{
    class ChangeParentComponent : MouseConsoleComponent
    {
        public override void ProcessMouse(SadConsole.Console console, MouseConsoleState state, out bool handled)
        {
            if (state.Mouse.RightClicked)
            {
                console.Parent = SadConsole.Global.CurrentScreen;
                console.Components.Remove(this);
            }

            handled = false;
        }
    }
}