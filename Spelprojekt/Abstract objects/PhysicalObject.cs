using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Abstract_objects
{
    class PhysicalObject : AccellerativeObject
    {
        // Variabler
        Rectangle[] hitboxes;

        // Konstruktorer
        public PhysicalObject(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, mass, friction, framerate, content)
        {
            texture = LoadAnimatedTexture(texturePath, content);

            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            updateStep = framerate / 60f;

            this.mass = mass;
            this.friction = friction;

            AutoHitbox();
        }

        public PhysicalObject(Texture2D texture, float X, float Y, float speedX, float speedY, float mass, float friction) : base(texture, X, Y, speedX, speedY, mass, friction)
        {
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            AutoHitbox();
        }

        public PhysicalObject(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, Rectangle[] hitboxes, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, mass, friction, framerate, content)
        {
            texture = LoadAnimatedTexture(texturePath, content);

            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            updateStep = framerate / 60f;

            this.mass = mass;
            this.friction = friction;

            this.hitboxes = hitboxes;
        }

        public PhysicalObject(Texture2D texture, float X, float Y, float speedX, float speedY, float mass, float friction, Rectangle[] hitboxes) : base(texture, X, Y, speedX, speedY, mass, friction)
        {
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            this.hitboxes = hitboxes;
        }
        /////////////////////////////////////////////////////////////////////////
        
        public Rectangle[] Hitboxes { get { return hitboxes; } set { hitboxes = value; } }

        public bool CheckCollision(Rectangle[] colliders, float targetLength, float targetX, float targetY)
        {
            if (Math.Sqrt(Math.Pow(targetX-CenterPosX, 2) + Math.Pow(targetY-CenterPosY, 2)) < targetLength)
            {
                bool status = false;

                foreach (Rectangle nuvarande in colliders)
                {
                    foreach (Rectangle nuvarande2 in hitboxes)
                    {
                        if (nuvarande.Intersects(nuvarande2)) status = true;
                    }
                }

                return status;
            }
            else return false;
        }

        private void AutoHitbox()
        {
            hitboxes = new Rectangle[1];
            hitboxes[1] = new Rectangle(new Point((int)X, (int)Y), new Point((int)Width, (int)Height));
        }
    }
}
