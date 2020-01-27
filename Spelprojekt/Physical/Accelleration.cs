using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Physical
{
    abstract class Accelleration
    {
        // Styrka på accelleration
        protected float accelleration;
        protected abstract Vector2 speed;

        public Accelleration(float accelleration)
        {
            this.accelleration = accelleration;
        }

        public void ApproachSpeed(Vector2 target)
        {

        }

        public void ApproachSpeed(Vector2 target, float accelleration)
        {

        }
    }
}
