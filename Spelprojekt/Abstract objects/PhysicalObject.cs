using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Physical;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Abstract_objects
{
    public abstract class PhysicalObject : AccellerativeObject
    {
        // Variabler
        protected Hitbox[] hitboxes;
        protected bool previousCollisionState = false;

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

        public PhysicalObject(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, Hitbox[] hitboxes, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, mass, friction, framerate, content)
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

        public PhysicalObject(Texture2D texture, float X, float Y, float speedX, float speedY, float mass, float friction, Hitbox[] hitboxes) : base(texture, X, Y, speedX, speedY, mass, friction)
        {
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            this.hitboxes = hitboxes;
        }
        /////////////////////////////////////////////////////////////////////////
        
        public Hitbox[] Hitboxes { get { return hitboxes; } set { hitboxes = value; } }



        public bool CheckCollision(Hitbox[] colliders, float targetLength, float targetX, float targetY)
        {


            



            
            if (Math.Sqrt(Math.Pow(targetX-CenterPosX, 2) + Math.Pow(targetY-CenterPosY, 2)) < targetLength)
            {
                bool status = false;

                foreach (Hitbox nuvarande in colliders)
                {
                    foreach (Hitbox nuvarande2 in hitboxes)
                    {
                        
                        if (nuvarande.Rectangle.Intersects(nuvarande2.Rectangle))
                        {
                            status = true;
                        }
                        

                        //Debug.WriteLine("Monster X: " + nuvarande2.Rectangle.X + " Monster Y: " + nuvarande2.Rectangle.Y);
                        //Debug.WriteLine("Skott X: " + nuvarande.Rectangle.X + " Skott Y: " + nuvarande.Rectangle.Y);

                        /*
                        if (nuvarande.Rectangle.X < nuvarande2.Rectangle.X + nuvarande.Rectangle.Width &&
                            nuvarande.Rectangle.X + nuvarande.Rectangle.Width > nuvarande2.Rectangle.X &&
                            nuvarande.Rectangle.Y < nuvarande2.Rectangle.Y + nuvarande2.Rectangle.Height &&
                            nuvarande.Rectangle.Y + nuvarande.Rectangle.Height > nuvarande2.Rectangle.Y)
                        {
                            return true;
                        }
                        */

                    }
                }

                return status;
            }
            else return false;
            
        }



        protected void AutoHitbox()
        {
            hitboxes = new Hitbox[1];
            hitboxes[0] = new Hitbox(new Rectangle(new Point((int)X, (int)Y), new Point((int)Width, (int)Height)), 0f, 0f);
        }

        protected void UpdateHitboxes()
        {
            foreach (Hitbox nuvarande in hitboxes)
            {
                nuvarande.UpdatePos(X, Y);
            }
        }
    }
}
