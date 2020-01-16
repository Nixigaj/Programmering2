using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelprojekt.Abstract_objects
{
    abstract class GameObject
    {
        protected Texture2D texture;
        protected Vector2 position;

        public GameObject(Texture2D texture, float X, float Y)
        {
            this.texture = texture;
            position.X = X;
            position.Y = Y;
        }

        public virtual void Update(GameWindow window) { }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public virtual float X { get { return position.X; } }
        public virtual float Y { get { return position.Y; } }
        public virtual float Width { get { return texture.Width; } }
        public virtual float Height { get { return texture.Height; } }
    }

    public interface IUpdate
    {
        void Update(GameWindow window);
    }
}