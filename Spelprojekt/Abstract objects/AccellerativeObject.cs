using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Physical
{
    class AccellerativeObject
    {
        // Styrka på accelleration
        protected float accelleration;
        protected Vector2 speed;
        protected float smoothing;

        public AccellerativeObject(float accelleration, float speedX, float speedY)
        {
            this.accelleration = accelleration;
            speed.X = speedX;
            speed.Y = speedY;
        }

        public void ApproachSpeed(Vector2 target)
        {
            if (speed.X < target.X)
            {
                
            }
            else
            {

            }
            if (speed.Y < target.Y)
            {

            }
            else
            {

            }
        }

        public void ApproachSpeed(Vector2 target, float accelleration)
        {

        }
    }
}
