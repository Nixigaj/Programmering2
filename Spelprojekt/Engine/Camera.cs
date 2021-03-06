﻿using Microsoft.Xna.Framework;
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
        private float windowWidth;

        public Camera(float X, float Y, float scale)
        {
            viewPos.X = X;
            viewPos.Y = Y;
            this.scale = scale;
            windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 1920f;
        }

        public Camera(float X, float Y)
        {
            viewPos.X = X;
            viewPos.Y = Y;
            scale = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 540f;
            windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / scale;
        }

        public void Update(GraphicsDeviceManager graphics, GraphicsDevice device)
        {
            // Uppdaterar skalan ifall fönstret har omformats
            scale = graphics.PreferredBackBufferHeight / 540f;
            windowWidth = device.Viewport.Width / scale;

            viewPos.X += speed.X;
            viewPos.Y += speed.Y;
        }

        public void ApproachPosition(float X, float Y, float speed, float intensity, float backwardsFactor)
        {
            ApproachX(X, intensity, speed, backwardsFactor);
            ApproachY(Y, intensity, speed);
        }

        public void ApproachX(float X, float speed, float intensity, float backwardsFactor)
        {
            float distance = X - viewPos.X;

            // Exponentiell hastighet relativt till distans
            if (distance > 0) this.speed.X = (float)Math.Pow(distance, intensity) * (speed / WidthFactor);
            else this.speed.X = (float)-Math.Pow(-distance, intensity) * (speed / WidthFactor) * backwardsFactor;
        }

        public void ApproachY(float Y, float speed, float intensity)
        {
            float distance = Y - viewPos.Y;

            // Exponentiell hastighet relativt till distans
            if (distance > 0) this.speed.Y = (float)Math.Pow(distance, intensity) * speed;
            else this.speed.Y = (float)-Math.Pow(-distance, intensity) * speed;

        }

        public float Scaling { get { return scale; } }
        public float WindowWidth { get { return windowWidth;  } }
        public float WidthFactor { get { return windowWidth / 960f; } }

        // Inverterat eftersom att kameran ska följa efter
        public Vector2 ViewPos { get { return -viewPos; } }
        public float X { get { return -viewPos.X; } }
        public float Y { get { return -viewPos.Y; } }
    }
}
