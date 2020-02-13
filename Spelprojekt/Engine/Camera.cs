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
        private float wscale;

        public Camera(float X, float Y, float scale)
        {
            viewPos.X = X;
            viewPos.Y = Y;
            this.scale = scale;
            wscale = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 1920f;
        }

        public Camera(float X, float Y)
        {
            viewPos.X = X;
            viewPos.Y = Y;
            scale = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 540f;
            wscale = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 1920f;
        }

        public void Update(GraphicsDeviceManager graphics)
        {
            // Uppdaterar skalan ifall fönstret har omformats
            scale = graphics.PreferredBackBufferHeight / 540f;
            wscale = graphics.PreferredBackBufferHeight / 1920f;

            viewPos.X += speed.X;
            viewPos.Y += speed.Y;
        }

        public void ApproachPosition(float X, float Y, float speed, float intensity)
        {
            ApproachX(X, intensity, speed);
            ApproachY(Y, intensity, speed);
        }

        public void ApproachX(float X, float speed, float intensity)
        {
            float distance = X - viewPos.X;

            // Exponentiell distans
            if (distance > 0) this.speed.X = (float)Math.Pow(distance, intensity) * speed;
            else this.speed.X = (float)-Math.Pow(-distance, intensity) * speed*4;
        }

        public void ApproachY(float Y, float speed, float intensity)
        {
            float distance = Y - viewPos.Y;

            // Exponentiell distans
            if (distance > 0) this.speed.Y = (float)Math.Pow(distance, intensity) * speed;
            else this.speed.Y = (float)-Math.Pow(-distance, intensity) * speed*4;

        }

        public float Scaling { get { return scale; } }
        public float WScale { get { return wscale;  } }
        public Vector2 ViewPos { get { return -viewPos; } }
        public float X { get { return -viewPos.X; } }
        public float Y { get { return -viewPos.Y; } }
    }
}
