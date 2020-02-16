using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Spelprojekt.Control
{
    class Mouse
    {
        static MouseState currentMouseState;
        static MouseState previousMouseState;

        public static Vector2 mousePos()
        {
            Vector2 pos;
            pos.X = currentMouseState.X;
            pos.Y = currentMouseState.Y;
            return pos;
        }

        public static MouseState GetState()
        {
            previousMouseState = currentMouseState;
            currentMouseState = Microsoft.Xna.Framework.Input.Mouse.GetState();
            return currentMouseState;
        }

        public static bool IsPressed(MouseKey key)
        {
            switch(key)
            {
                case MouseKey.LeftButton: return currentMouseState.LeftButton == ButtonState.Pressed;
                case MouseKey.MiddleButton: return currentMouseState.MiddleButton == ButtonState.Pressed;
                case MouseKey.RightButton: return currentMouseState.RightButton == ButtonState.Pressed;
                default: return false;
            }
        }

        public static bool HasBeenPressed(MouseKey key)
        {
            switch (key)
            {
                case MouseKey.LeftButton: return (currentMouseState.LeftButton == ButtonState.Pressed) && !(previousMouseState.LeftButton == ButtonState.Pressed);
                case MouseKey.MiddleButton: return (currentMouseState.MiddleButton == ButtonState.Pressed) && !(previousMouseState.MiddleButton == ButtonState.Pressed);
                case MouseKey.RightButton: return (currentMouseState.RightButton == ButtonState.Pressed) && !(previousMouseState.RightButton == ButtonState.Pressed);
                default: return false;
            }
            
        }
    }

    enum MouseKey
    {
        LeftButton, MiddleButton, RightButton
    }
}
