using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Microsoft.Xna.Framework.Content;
using System;

namespace Spelprojekt.Abstract_objects
{
    abstract class GameObject
    {
        // Variabler
        protected float currentTexture = 0;
        protected Texture2D[] texture;
        protected Vector2 position;
        protected float scale = 1;
        protected float updateStep;
        private float x;
        private float y;

        // Konstruktorer
        public GameObject(string texturePath, float X, float Y, int framerate, ContentManager content)
        {
            // Hur många texturer som ska användas
            int tCount = Directory.GetFiles("" + texturePath, "*", SearchOption.AllDirectories).Length;
            //                                    ^^^ Detta kanske måste åtgärdas senare

            texture = new Texture2D[tCount];
            for (int i = 1; i <= tCount; i++)
            {
                texture[i - 1] = content.Load<Texture2D>(texturePath+"/"+i.ToString());
            }

            position.X = X;
            position.Y = Y;

            updateStep = framerate / 60f;
        }

        public GameObject(Texture2D texture, float X, float Y)
        {
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;
        }

        ////////////////////////////////////

        public virtual void Update(GameWindow window)
        {
            IncrementTexture();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture[(int)currentTexture], position, Color.White);
        }

        public virtual void IncrementTexture()
        {
            if (currentTexture + updateStep < texture.Length + 1) currentTexture += updateStep;
            else currentTexture = (currentTexture + updateStep) - texture.Length;
        }

        public virtual void IncrementTexture(int frameAmount)
        {
            if (currentTexture + frameAmount < texture.Length + 1) currentTexture += frameAmount;
            else currentTexture = (currentTexture + frameAmount) - texture.Length;
        }


        
        public virtual float X { get { return position.X; } }
        public virtual float Y { get { return position.Y; } }
        public virtual float Width { get { return texture[(int)currentTexture].Width; } }
        public virtual float Height { get { return texture[(int)currentTexture].Height; } }
        //Retunerar center-koordinat för objekt
        public virtual float CenterPosX
        {   
            get
            {
                return position.X + (texture[(int)currentTexture].Width / 2);
            }
        }
        public virtual float CenterPosY
        {
            get
            {
                return position.Y + (texture[(int)currentTexture].Height / 2);
            }
        }
    }

    public interface IUpdate
    {
        void Update(GameWindow window);
    }
}