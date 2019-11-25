/// KONTROLLER:
///
/// W: Framåt
/// A: Vänster
/// S: Bakåt
/// D: Höger
/// Mellanslag: Färdas snabbare
/// Vänster shift: Lämna svans efter dig

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using SpaceShooter.Abstract_objects;

namespace SpaceShooter.Entities
{
    class Player : MovingObject
    {
        float boostValue;

        public Player(Texture2D texture, float X, float Y, float speedX, float speedY, float boost) : base(texture, X, Y, speedX, speedY)
        {
            this.texture = texture;
            vector.X = X;
            vector.Y = Y;
            speed.X = speedX;
            speed.Y = speedY;
            boostValue = boost;
        }

        public override void Update(GameWindow window)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (vector.X <= window.ClientBounds.Width - texture.Width && vector.X >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.D))
                {
                    if (keyboardState.IsKeyDown(Keys.LeftShift)) vector.X += speed.X + boostValue;
                    else vector.X += speed.X;
                }
                if (keyboardState.IsKeyDown(Keys.A))
                {
                    if (keyboardState.IsKeyDown(Keys.LeftShift)) vector.X -= speed.X + boostValue;
                    else vector.X -= speed.X;
                }
            }

            if (vector.Y <= window.ClientBounds.Height - texture.Height && vector.Y >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.S))
                {
                    if (keyboardState.IsKeyDown(Keys.LeftShift)) vector.Y += speed.Y + boostValue;
                    else vector.Y += speed.Y;
                }
                if (keyboardState.IsKeyDown(Keys.W))
                {
                    if (keyboardState.IsKeyDown(Keys.LeftShift)) vector.Y -= speed.Y + boostValue;
                    else vector.Y -= speed.Y;
                }
            }

            if (vector.X < 0) vector.X = 0;
            if (vector.X > window.ClientBounds.Width - texture.Width) vector.X = window.ClientBounds.Width - texture.Width;

            if (vector.Y < 0) vector.Y = 0;
            if (vector.Y > window.ClientBounds.Height - texture.Height) vector.Y = window.ClientBounds.Height - texture.Height;
        }


    }
}
