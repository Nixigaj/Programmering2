using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spelprojekt.Abstract_objects;
using Spelprojekt.Physical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Entities.Player
{
    public class Bullet : PhysicalObject
    {
        private float hitboxStepX;
        private float hitboxStepY;

        public Bullet(string texturePath, float X, float Y, float speedX, float speedY, float mass, float friction, float rotation, int framerate, ContentManager content) : base(texturePath, X, Y, speedX, speedY, mass, friction, framerate, content)
        {
            texture = LoadAnimatedTexture(texturePath, content, 4);

            this.rotation = rotation;

            position.X = X;
            position.Y = Y;

            speed.X = GetSpeedX();
            speed.Y = GetSpeedY();

            hitboxStepX = speed.X / 9f;
            hitboxStepY = speed.Y / 9f;

            updateStep = framerate / 60f;

            SetHitboxes();
        }

        public void Update()
        {
            ApplySpeed();
            UpdateHitboxes();
            IncrementTexture();
        }

        private void SetHitboxes()
        {
            hitboxes = new Hitbox[10];

            hitboxes[0] = new Hitbox(new Rectangle(new Point((int)X, (int)Y), new Point((int)Width, (int)Height)), 0f, 0f);

            for (int i = 1; i < 10; i++)
            {
                hitboxes[i] = new Hitbox(new Rectangle(new Point((int)X, (int)Y), new Point((int)Width, (int)Height)), -i * hitboxStepX, -i * hitboxStepY);
            }
        }

        private float GetSpeedX()
        {
            return (float) Math.Cos(rotation) * 25f;
        }

        private float GetSpeedY()
        {
            return (float) Math.Sin(rotation) * 25f;
        }
    }
}
