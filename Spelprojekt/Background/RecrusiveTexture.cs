using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using System.Collections.Generic;

namespace Spelprojekt.Background
{
    class RecrusiveTexture : GameObject
    {
        // Hur många texturer som bredd och höjd
        private int iterationsX;
        private int iterationsY;

        public RecrusiveTexture(Texture2D texture, float X, float Y, int iterationsX, int iterationsY) : base(texture, X, Y)
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            float offsetY = 0;
            for (int i = 0; i < iterationsY; i++)
            {
                float offsetX = 0;
                for (int j = 0; j < iterationsX; j++)
                {
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
            position.X += speedNudgeX;
            position.Y += speedNudgeY;
        }

        //public override float X { get { return position.X; } }
        //public override float Y { get { return position.Y; } }
        public override float Width { get { return texture.Width * iterationsX; } }
        public override float Height { get { return texture.Height * iterationsY; } }
    }
}