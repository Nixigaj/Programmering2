using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace Spelprojekt.Abstract_objects
{
    abstract class MovingObject : GameObject
    {
        protected Vector2 speed;

        // Konstruktorer
        public MovingObject(string texturePath, float X, float Y, float speedX, float speedY, int framerate, ContentManager content) : base(texturePath, X, Y, framerate, content)
        {
            texture = LoadAnimatedTexture(texturePath, content);

            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;

            updateStep = framerate / 60f;
        }

        public MovingObject(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y)
        {
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;

            speed.X = speedX;
            speed.Y = speedY;
        }
        //////////////////////////////////

        public void ApplySpeed()
        {

        }
    }
}
