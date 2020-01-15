using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using System;
using System.Collections.Generic;

namespace Spelprojekt.Background
{
    class RecrusiveTexture : MovingObject
    {
        // Hur många paneler som ska ritas ut
        private int iterationsX;
        // När nästa rad av texturer ska ritas
        private int iterationsY;

        // Lista på alla moving objects som ska ritas ut
        private List<MovingObject> panels;

        public RecrusiveTexture(Texture2D texture, float X, float Y, float speedX, float speedY,)
        {
            
            
        }

        public RecrusiveTexture(Texture2D texture, float X, float Y, float speedX, float speedY, int iterationsX, int iterationsY) : base(texture, X, Y, speedX, speedY)
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;

            for (int i = 0; i < iterationsY; i++)
            {
                float offsetY = 0;
                for (int j = 0; j < iterationsX; j++)
                {
                    float offsetX = 0;
                    panels.Add(new MovingObject(texture, X + offsetX, Y + offsetY, speedX, speedY));
                    offsetX += texture.Width;
                }
                offsetY += texture.Height;

            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, Color.White);
        }

        public override void Update(GameWindow window)
        {
            throw new NotImplementedException();
        }

        public float X { get { return vector.X; } }
        public float Y { get { return vector.Y; } }
        public float Width { get { return texture.Width; } }
        public float Height { get { return texture.Height; } }
    }
}