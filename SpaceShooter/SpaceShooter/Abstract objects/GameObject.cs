using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter.Abstract_objects
{
    abstract class GameObject : IUpdate
    {
        protected Texture2D texture;
        protected Vector2 vector;

        public GameObject(Texture2D texture, float X, float Y)
        {
            this.texture = texture;
            vector.X = X;
            vector.Y = Y;
        }

        public virtual void Update(GameWindow window) { }

        public virtual void Draw(SpriteBatch spriteBatch, Vector2 cameraPos)
        {
            spriteBatch.Draw(texture, vector + cameraPos, Color.White);
        }

        public float X { get { return vector.X; } }
        public float Y { get { return vector.Y; } }
        public float Width { get { return texture.Width; } }
        public float Height { get { return texture.Height; } }
    }

    public interface IUpdate
    {
        void Update(GameWindow window);
    }
}