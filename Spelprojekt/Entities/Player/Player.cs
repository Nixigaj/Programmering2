using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spelprojekt.Physical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Entities.Player
{
    class Player : AccellerativeObject
    {
        public Player(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, mass, friction, framerate, content)
        {
            texture = LoadAnimatedTexture(texturePath, content);

            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            updateStep = framerate / 60f;

            this.mass = mass;
            this.friction = friction;
        }

        public override void Update(GameWindow window)
        {
            ApplyMovement();
            ApplyFriction();

            KeyboardState keyboardState = Keyboard.GetState();

            
            if (keyboardState.IsKeyDown(Controls.framåt))
            {
                ApplyForceX(0.1f);
            }
            if (keyboardState.IsKeyDown(Controls.bakåt))
            {
                ApplyForceX(-0.1f);
            }

            if (keyboardState.IsKeyDown(Controls.neråt))
            {
                ApplyForceY(0.1f);
            }
            if (keyboardState.IsKeyDown(Controls.uppåt))
            {
                ApplyForceY(-0.1f);
            }

            if (speed.X > 1f) speed.X = 1f;
            if (speed.X < -1f) speed.X = -1f;

            if (speed.Y > 1f) speed.Y = 1f;
            if (speed.Y < -1f) speed.Y = -1f;

            /*
            if (speed.X < 0) speed.X = 0;
            if (speed.X > window.ClientBounds.Width - Width) speed.X = window.ClientBounds.Width - Width;

            if (speed.Y < 0) speed.Y = 0;
            if (speed.Y > window.ClientBounds.Height - Height) speed.Y = window.ClientBounds.Height - Height;
            */

            IncrementTexture();
        }
    }
}
