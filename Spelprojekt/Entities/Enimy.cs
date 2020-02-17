using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spelprojekt.Abstract_objects;
using Spelprojekt.Entities.Player;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Entities
{
    public class Enimy : PhysicalObject
    {
        public Enimy(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, mass, friction, framerate, content)
        {
            texture = LoadAnimatedTexture(texturePath, content, 4);

            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            updateStep = framerate / 60f;

            this.mass = mass;
            this.friction = friction;

            AutoHitbox();
        }

        public bool Update(float targetX, float targetY, List<Bullet> bullets, float intensity)
        {
            ApplyMovement();
            ApplyFriction();
            IncrementTexture();

            ApproachTarget(targetX, targetY, intensity);


            UpdateHitboxes();



            if (!(bullets == null))
            {
                bool collided = false;
                foreach (Bullet nuvarande in bullets)
                {
                    if (CheckCollision(nuvarande.Hitboxes, 100f, nuvarande.CenterPosX, nuvarande.CenterPosY)) collided = true;
                }
                if (!previousCollisionState && collided)
                {
                    previousCollisionState = true;
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
        }

        private void ApproachTarget(float targetX, float targetY, float intensity)
        {
            float effectiveIntensity = (float)Math.Pow(intensity, 0.1);
            if (X < targetX) ApplyForceX(0.05f * effectiveIntensity);
            if (X > targetX) ApplyForceX(-0.05f * effectiveIntensity);

            if (Y < targetY) ApplyForceY(0.05f * effectiveIntensity);
            if (Y > targetY) ApplyForceY(-0.05f * effectiveIntensity);
        }
    } 
}
