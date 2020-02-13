using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Engine
{
    public class Camera
    {
        Vector2 speed;
        private static Vector2 viewPos = new Vector2(0f, 0f);
        // Standard för 1080p skärmar eftersom att texturerna är hälften så höga
        private float scale = 2;

        public Camera(float X, float Y, float scale)
        {
            viewPos.X = X;
            viewPos.Y = Y;
            this.scale = scale;
        }

        public Camera(float X, float Y)
        {
            viewPos.X = X;
            viewPos.Y = Y;
            scale = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 540f;
        }

        public void Update(GraphicsDeviceManager graphics)
        {
            scale = graphics.PreferredBackBufferHeight / 540f;
        }

        public void ApproachPosition(float X, float Y, float intensity)
        {

        }

        public void ApproachX(float X, float intensity)
        {
            
        }

        public void ApproachY(float Y, float intensity)
        {

        }

        public float Scaling { get { return scale; } }
        public Vector2 ViewPos { get { return -viewPos; } }
        public float X { get { return -viewPos.X; } }
        public float Y { get { return -viewPos.Y; } }
    }
}
