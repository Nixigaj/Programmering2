using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Spelprojekt.Engine;
using System;

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

        public static MouseState GetStateLocal()
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
            previousMouseState = currentMouseState;
            currentMouseState = Microsoft.Xna.Framework.Input.Mouse.GetState();
            switch (key)
            {
                case MouseKey.LeftButton: return (currentMouseState.LeftButton == ButtonState.Pressed) && !(previousMouseState.LeftButton == ButtonState.Pressed);
                case MouseKey.MiddleButton: return (currentMouseState.MiddleButton == ButtonState.Pressed) && !(previousMouseState.MiddleButton == ButtonState.Pressed);
                case MouseKey.RightButton: return (currentMouseState.RightButton == ButtonState.Pressed) && !(previousMouseState.RightButton == ButtonState.Pressed);
                default: return false;
            }
        }

        // Rotation och postitionshantering
        public static float RelativeRotation(Camera camera, float X, float Y)
        {
            return (float) Math.Atan2(DeltaY(camera, Y), DeltaX(camera, X));
        }

        public static float DeltaX(Camera camera, float X)
        {
            return GamePosX(camera) - X;
        }

        public static float DeltaY(Camera camera, float Y)
        {
            return GamePosY(camera) - Y;
        }

        public static float GamePosX(Camera camera)
        {
            return (GetStateLocal().X / camera.Scaling + -camera.X);
        }

        public static float GamePosY(Camera camera)
        {
            return (GetStateLocal().Y / camera.Scaling + -camera.Y);
        }
        /////////////////////////////////////////////////
    }

    enum MouseKey
    {
        LeftButton, MiddleButton, RightButton
    }


}
