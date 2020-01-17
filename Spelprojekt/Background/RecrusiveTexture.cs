using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using System;
using System.Collections.Generic;

namespace Spelprojekt.Background
{
    class RecrusiveTexture : GameObject
    {
        // Hur många paneler som ska ritas ut
        private int iterationsX;
        // När nästa rad av texturer ska ritas
        private int iterationsY;

        // Lista på alla moving objects som ska ritas ut
        private List<MovingObject> panels;

        public RecrusiveTexture(Texture2D texture, float X, float Y, int iterationsX, int iterationsY) : base(texture, X, Y)
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < iterationsY; i++)
            {
                float offsetY = 0;
                for (int j = 0; j < iterationsX; j++)
                {
                    float offsetX = 0;
                    spriteBatch.Draw(texture, new Vector2(position.X + offsetX, position.Y + offsetY), Color.White);
                    offsetX += texture.Width;
                }
                offsetY += texture.Height;
            }
        }

        public void ApproachSpeed(float frameFactor, float speedX, float speedY)
        {
            
        }

        public void Update(GameWindow window, float speedNudgeX, float speedNudgeY)
        {
            throw new NotImplementedException();
        }

        //public override float X { get { return position.X; } }
        //public override float Y { get { return position.Y; } }
        public override float Width { get { return texture.Width * iterationsX; } }
        public override float Height { get { return texture.Height * iterationsY; } }
    }
}