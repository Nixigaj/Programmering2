using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Engine
{
    class Camera
    {

        public static Vector2 viewPos = new Vector2(0f, 0f);


        public virtual float X { get { return viewPos.X; } }
        public virtual float Y { get { return viewPos.Y; } }
    }
}
