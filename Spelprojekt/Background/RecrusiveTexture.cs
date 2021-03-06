﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using Spelprojekt.Engine;
using Spelprojekt.Physical;
using System.IO;

namespace Spelprojekt.Background
{
    public class RecrusiveTexture : GameObject
    {
        // Hur många texturer som bredd och höjd
        protected int iterationsX;
        protected int iterationsY;
        protected float fullWidth;
        protected float fullHeight;
        protected float parralaxFactor = 1;

        // Konstruktorer
        public RecrusiveTexture(string texturePath, float X, float Y, int iterationsX, int iterationsY, int framerate, float parralaxIntensity, ContentManager content) : base(texturePath, X, Y, framerate, content)
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;

            texture = LoadAnimatedTexture(texturePath, content);
            position.X = X;
            position.Y = Y;

            updateStep = framerate / 60f;

            fullWidth = texture[0].Width * iterationsX;
            fullHeight = texture[0].Height * iterationsY;

            parralaxFactor = parralaxIntensity + 1;
        }

        public RecrusiveTexture(Texture2D texture, float X, float Y, int iterationsX, int iterationsY, float parralaxIntensity) : base (texture, X ,Y)
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;

            /*
            this.texture = new Texture2D[1];
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;
            */

            fullWidth = this.texture[0].Width * iterationsX;
            fullHeight = this.texture[0].Height * iterationsY;
        }



        ///////////////////////////////
        // Draw funktioner
        public override void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            float offsetY = 0;
            for (int i = 0; i < iterationsY; i++)
            {
                float offsetX = 0;
                for (int j = 0; j < iterationsX; j++)
                {
                    spriteBatch.Draw(texture[(int)currentTexture], new Vector2(position.X + offsetX + (camera.X/parralaxFactor), position.Y + offsetY + (camera.Y/parralaxFactor)), Color.White);
                    offsetX += texture[(int)currentTexture].Width;
                }
                offsetY += texture[(int)currentTexture].Height;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Camera camera, int xSlack, int ySlack)
        {
            float offsetY = 0;
            for (int i = 0; i < iterationsY; i++)
            {
                float offsetX = 0;
                for (int j = 0; j < iterationsX; j++)
                {
                    spriteBatch.Draw(texture[(int)currentTexture], new Vector2(position.X + offsetX + (camera.X / parralaxFactor) + (xSlack*Width), position.Y + offsetY + (camera.Y / parralaxFactor) + (ySlack * Height)), Color.White);
                    offsetX += texture[(int)currentTexture].Width;
                }
                offsetY += texture[(int)currentTexture].Height;
            }
        }
        //////////////////////////////
        // Bra för rekrusiva texturer som ska repeteras
        public void Nudge(int nudgeX, int nudgeY)
        {
            NudgeX(nudgeX);
            NudgeY(nudgeY);
        }

        public void NudgeX(int nudgeAmount)
        {
            position.X += nudgeAmount * texture[0].Width;
        }

        public void NudgeY(int nudgeAmount)
        {
            position.Y += nudgeAmount * texture[0].Height;
        }
        ////////////////////////////////////////////////

        /*
        public void Move(float moveX, float moveY)
        {
            position.X += moveX;
            position.Y += moveY;
        }
        */

        //public override float X { get { return position.X; } }
        //public override float Y { get { return position.Y; } }
        public float FullWidth { get { return fullWidth; } }
        public float FullHeight { get { return fullHeight; } }
        public int IterationsX { get { return iterationsX; } set { iterationsX = value; } }
        public int IterationsY { get { return iterationsY; } set { iterationsY = value; } }
        public float ParralaxFactor { get { return parralaxFactor; } }
    }
}