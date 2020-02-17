using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Abstract_objects
{
    public abstract class AccellerativeObject : MovingObject
    {
        // Styrka på accelleration
        //protected Vector2 accelleration;
        protected float mass;
        protected float friction;

        // Konstruktorer
        public AccellerativeObject(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, framerate, content)
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

        public AccellerativeObject(Texture2D texture, float X, float Y, float speedX, float speedY, float mass, float friction) : base(texture, X, Y, speedX, speedY)
        {
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;
        }
        ////////////////////////////////////
        
        // Kraftapplicering
        public void ApplyForce(float forceX, float forceY)
        {
            ApplyForceX(forceX);
            ApplyForceY(forceY);
        }

        public void ApplyForceX(float forceX)
        {
            speed.X += forceX;
        }

        public void ApplyForceY(float forceY)
        {
            speed.Y += forceY;
        }
        //////////////////////////////////////////////////////////////

        public void ApplyFriction()
        {
            if (speed.X > friction / mass) ApplyForceX(-friction / mass);
            else if (speed.X < -friction / mass) ApplyForceX(friction / mass);
            else speed.X = 0;

            if (speed.Y > friction / mass) ApplyForceY(-friction / mass);
            else if (speed.Y < -friction / mass) ApplyForceY(friction / mass);
            else speed.Y = 0;
        }

        public void ApplyMovement()
        {
            ApplySpeed(speed.X / mass, speed.Y / mass);
        }

        public override void Update(GameWindow window)
        {
            ApplyMovement();
            ApplyFriction();

            

            IncrementTexture();
        }












        //public AccellerativeObject(float accelleration, float speedX, float speedY)
        //{
        //    this.accelleration = accelleration;
        //    speed.X = speedX;
        //    speed.Y = speedY;
        //}

        //public void ApproachSpeed(Vector2 target)
        //{
        //    if (speed.X < target.X)
        //    {

        //    }
        //    else
        //    {

        //    }
        //    if (speed.Y < target.Y)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        //public void ApproachSpeed(Vector2 target, float accelleration)
        //{

        //}
    }
}
