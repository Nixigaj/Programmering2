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
            // Uppdaterar skalan ifall fönstret har omformats
            scale = graphics.PreferredBackBufferHeight / 540f;

            viewPos.X += speed.X;
            viewPos.Y += speed.Y;
        }

        public void ApproachPosition(float X, float Y, float intensity)
        {
            ApproachX(X, intensity);
            ApproachY(Y, intensity);
        }

        public void ApproachX(float X, float intensity)
        {
            float distance = viewPos.X - X;
            // Exponentiell distans
            speed.X = distance * distance * intensity;
        }

        public void ApproachY(float Y, float intensity)
        {
            float distance = viewPos.Y - Y;
            // Exponentiell distans
            speed.Y = distance * distance * intensity;
        }

        public float Scaling { get { return scale; } }
        public Vector2 ViewPos { get { return -viewPos; } }
        public float X { get { return -viewPos.X; } }
        public float Y { get { return -viewPos.Y; } }
    }
}
