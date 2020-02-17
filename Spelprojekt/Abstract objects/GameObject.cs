using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Microsoft.Xna.Framework.Content;
using System;
using Spelprojekt.Engine;

namespace Spelprojekt.Abstract_objects
{
    public abstract class GameObject
    {
        // Variabler
        protected float currentTexture = 0;
        protected Texture2D[] texture;
        protected Vector2 position;
        protected float updateStep;
        protected float rotation = 0;
        //private float x;
        //private float y;

        // Konstruktorer
        public GameObject(string texturePath, float X, float Y, int framerate, ContentManager content)
        {
            texture = LoadAnimatedTexture(texturePath, content);

            position.X = X;
            position.Y = Y;

            updateStep = framerate / 60f;

            //width = texture[0].Width;
        }

        
        public GameObject(Texture2D texture, float X, float Y)
        {
            this.texture = new Texture2D[1];
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;
        }

        public GameObject(string texturePath, float X, float Y, float rotation, int framerate, ContentManager content)
        {
            texture = LoadAnimatedTexture(texturePath, content);

            position.X = X;
            position.Y = Y;

            updateStep = framerate / 60f;

            this.rotation = rotation;

            //width = texture[0].Width;
        }


        public GameObject(Texture2D texture, float X, float Y, float rotation)
        {
            this.texture = new Texture2D[1];
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;

            this.rotation = rotation;
        }

        ////////////////////////////////////

        public virtual void Update(GameWindow window)
        {
            IncrementTexture();
        }

        public virtual void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            spriteBatch.Draw(texture[(int)currentTexture], position + camera.ViewPos, Color.White);
        }

        public virtual void DrawRotation(SpriteBatch spriteBatch, Camera camera)
        {
            spriteBatch.Draw(texture[(int)currentTexture], position + camera.ViewPos, null, null, new Vector2(Width/2, Height/2), rotation, null, Color.White, SpriteEffects.None);
        }

        public virtual void IncrementTexture()
        {
            if (currentTexture + updateStep < texture.Length) currentTexture += updateStep;
            else currentTexture = (currentTexture + updateStep) - texture.Length;
        }

        public virtual void IncrementTexture(int frameAmount)
        {
            if (currentTexture + frameAmount < texture.Length) currentTexture += frameAmount;
            else currentTexture = (currentTexture + frameAmount) - texture.Length;
        }

        protected virtual Texture2D[] LoadAnimatedTexture(string texturePath, ContentManager content)
        {
            // Hur många texturer som ska användas
            int tCount = Directory.GetFiles("../../../../Content/" + texturePath, "*.png", SearchOption.AllDirectories).Length;
            //                                    ^^^ Detta kanske måste åtgärdas senare

            texture = new Texture2D[tCount];
            for (int i = 1; i <= tCount; i++)
            {
                texture[i - 1] = content.Load<Texture2D>(texturePath + "/" + i.ToString());
            }

            return texture;
        }

        protected virtual Texture2D[] LoadAnimatedTexture(string texturePath, ContentManager content, int tCount)
        {
            texture = new Texture2D[tCount];
            for (int i = 1; i <= tCount; i++)
            {
                texture[i - 1] = content.Load<Texture2D>(texturePath + "/" + i.ToString());
            }

            return texture;
        }

        public virtual float X { get { return position.X; } set { position.X = value; } }
        public virtual float Y { get { return position.Y; } set { position.Y = value; } }
        public virtual float Width { get { return texture[(int)currentTexture].Width; } }
        public virtual float Height { get { return texture[(int)currentTexture].Height; } }
        public virtual float Rotation { get { return rotation; } }

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