using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using Spelprojekt.Physical;
using System.IO;

namespace Spelprojekt.Background
{
    class RecrusiveTexture : GameObject
    {
        // Hur många texturer som bredd och höjd
        protected int iterationsX;
        protected int iterationsY;
        protected float width;
        protected float height;

        // Konstrukyorer
        public RecrusiveTexture(string texturePath, float X, float Y, int iterationsX, int iterationsY, int framerate, ContentManager content) : base(texturePath, X, Y, framerate, content)
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;

            // Hur många texturer som ska användas
            int tCount = Directory.GetFiles("" + texturePath, "*", SearchOption.AllDirectories).Length;
            //                                    ^^^ Detta kanske måste åtgärdas senare

            texture = new Texture2D[tCount];
            for (int i = 1; i <= tCount; i++)
            {
                texture[i - 1] = content.Load<Texture2D>(texturePath + "/" + i.ToString());
            }

            position.X = X;
            position.Y = Y;

            updateStep = framerate / 60f;

            width = texture[0].Width * iterationsX;
            height = texture[0].Height * iterationsY;
        }

        public RecrusiveTexture(Texture2D texture, float X, float Y, int iterationsX, int iterationsY) : base (texture, X ,Y)
        {
            this.iterationsX = iterationsX;
            this.iterationsY = iterationsY;

            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;

            width = this.texture[0].Width * iterationsX;
            height = this.texture[0].Height * iterationsY;
        }



        ///////////////////////////////

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

        public void Move(float moveX, float moveY)
        {
            position.X += moveX;
            position.Y += moveY;
        }

        //public override float X { get { return position.X; } }
        //public override float Y { get { return position.Y; } }
        public override float Width { get { return width; } }
        public override float Height { get { return height; } }
    }
}