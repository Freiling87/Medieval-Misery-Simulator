using SadConsole.Components;
using SadConsole.Input;
using Microsoft.Xna.Framework;

class MouseMoveComponent : MouseConsoleComponent
{
    public override void ProcessMouse(SadConsole.Console console, MouseConsoleState state, out bool handled)
    {
        if (state.Mouse.IsOnScreen)
            console.Position = state.WorldCellPosition;

        handled = true;
    }
}