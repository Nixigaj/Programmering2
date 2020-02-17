using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spelprojekt.Abstract_objects;
using Spelprojekt.Gamestates;
using Spelprojekt.Physical;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Entities.Player
{
    class Ship : PhysicalObject
    {
        public Ship(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, mass, friction, framerate, content)
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

        int waitFrame = 0;

        public bool Update(GameWindow window, List<Enimy> enimies)
        {
            ApplyMovement();
            ApplyFriction();

            DirectionControlsNew();
            LimitBounraries();

            IncrementTexture();
             
            UpdateHitboxes();

            if (!(enimies == null))
            {
                bool collided = false;
                foreach (Enimy nuvarande in enimies)
                {

                    if (CheckCollision(nuvarande.Hitboxes, 200f, nuvarande.CenterPosX, nuvarande.CenterPosY))
                    {
                        collided = true;
                        waitFrame++;
                    }
                }
                if ((!previousCollisionState && collided) || waitFrame > 30)
                {
                    Debug.WriteLine("Kollision!");
                    previousCollisionState = true;
                    waitFrame = 0;
                    return true;
                }
                else if (previousCollisionState && !collided)
                {
                    previousCollisionState = false;
                    return false;
                }
                else return false;
            }
            else return false;




            /*
            if (!Keyboard.IsPressed(Keys.LeftShift))
            {
                if (speed.X > 1f) speed.X = 1f;
                if (speed.X < -1f) speed.X = -1f;

                if (speed.Y > 1f) speed.Y = 1f;
                if (speed.Y < -1f) speed.Y = -1f;
            }
            */

            /*
            if (speed.X < 0) speed.X = 0;
            if (speed.X > window.ClientBounds.Width - Width) speed.X = window.ClientBounds.Width - Width;

            if (speed.Y < 0) speed.Y = 0;
            if (speed.Y > window.ClientBounds.Height - Height) speed.Y = window.ClientBounds.Height - Height;
            */
        }

        private void LimitBounraries()
        {
            if (Y + Height > Gamestate1.unit - 64 - 10)
            {
                ApplyForceY((float) -(Math.Pow(Y + Height - (Gamestate1.unit - 64 - 10), 1.5f) * 0.01f));
            }
            else if (Y < 64 + 10)
            {
                ApplyForceY((float)(Math.Pow((64 + 10) - Y, 1.5f) * 0.01f));
            }
        }

        private void DirectionControlsNew()
        {
            if (Keyboard.IsPressed(Control.Controls.framåt) && !Keyboard.IsPressed(Control.Controls.bakåt) && !TooFastX())
            {
                ApplyForceX(0.1f);
            }
            if (Keyboard.IsPressed(Control.Controls.bakåt) && !Keyboard.IsPressed(Control.Controls.framåt) && !TooFastX())
            {
                ApplyForceX(-0.1f);
            }

            if (Keyboard.IsPressed(Control.Controls.uppåtKraft) && !TooFastY())
            {
                ApplyForceY(-0.1f);
            }
            else if (!TooFastY())
            {
                ApplyForceY(0.1f);
            }
        }

        private void DirectionControlsOld()
        {
            if (Keyboard.IsPressed(Control.Controls.framåt) && !Keyboard.IsPressed(Control.Controls.bakåt) && !TooFastX())
            {
                ApplyForceX(0.1f);
            }
            if (Keyboard.IsPressed(Control.Controls.bakåt) && !Keyboard.IsPressed(Control.Controls.framåt) && !TooFastX())
            {
                ApplyForceX(-0.1f);
            }

            if (Keyboard.IsPressed(Control.Controls.neråt) && !Keyboard.IsPressed(Control.Controls.uppåt) && !TooFastY())
            {
                ApplyForceY(0.1f);
            }
            if (Keyboard.IsPressed(Control.Controls.uppåt) && !Keyboard.IsPressed(Control.Controls.neråt) && !TooFastY())
            {
                ApplyForceY(-0.1f);
            }
        }

        private bool TooFastX()
        {
            if (Keyboard.IsPressed(Keys.LeftShift)) return false;
            if (speed.X > 1f) return true;
            if (speed.X < -1f) return true;
            else return false;
        }

        private bool TooFastY()
        {
            if (Keyboard.IsPressed(Keys.LeftShift)) return false;
            if (speed.Y > 1f) return true;
            if (speed.Y < -1f) return true;
            else return false;
        }
    }
}
