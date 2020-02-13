using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Physical
{
    class AccellerativeObject : MovingObject
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

        public void ApplyForce(float forceX, float forceY)
        {
            speed.X += forceX;
            speed.Y += forceY;
        }

        public override void Update(GameWindow window)
        {
            ApplySpeed(speed.X/mass, speed.Y/mass);



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
