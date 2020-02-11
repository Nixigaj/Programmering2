using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using Spelprojekt.Physical;

namespace Spelprojekt.Background
{
    class RecrusiveTexture : GameObject
    {
        // Hur många texturer som bredd och höjd
        protected int iterationsX;
        protected int iterationsY;
        protected float width;
        protected float height;

        public RecrusiveTexture(Texture2D[] texture, float X, float Y, int iterationsX, int iterationsY) : base(texture, X, Y, )
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;
            width = texture[0].Width * iterationsX;
            height = texture[0].Height * iterationsY;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            float offsetY = 0;
            for (int i = 0; i < iterationsY; i++)
            {
                float offsetX = 0;
                for (int j = 0; j < iterationsX; j++)
                {
                    spriteBatch.Draw(texture[(int)currentTexture], new Vector2(position.X + offsetX, position.Y + offsetY), Color.White);
                    offsetX += texture[(int)currentTexture].Width;
                }
                offsetY += texture[(int)currentTexture].Height;
            }
        }

        public void ApproachSpeed(float frameFactor, float speedX, float speedY)
        {
            
        }

        // Bra för rekrusiva texturer som ska repeteras
        public void Nudge(int NudgeX, int NudgeY)
        {
            position.X += NudgeX * texture[0].Width;
            position.Y += NudgeY * texture[0].Height;
        }

        //public override float X { get { return position.X; } }
        //public override float Y { get { return position.Y; } }
        public override float Width { get { return width; } }
        public override float Height { get { return height; } }
    }
}