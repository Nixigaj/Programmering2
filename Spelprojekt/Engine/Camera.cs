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
        // Standard för 1080p skärmar
        private float scale = 2;
        private static Vector2 viewPos = new Vector2(0f, 0f);



        public virtual Vector2 ViewPos { get { return viewPos; } }
        public virtual float X { get { return viewPos.X; } }
        public virtual float Y { get { return viewPos.Y; } }
    }
}
