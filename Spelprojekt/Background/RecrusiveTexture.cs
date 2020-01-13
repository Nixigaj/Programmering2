using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using System;
using System.Collections.Generic;

namespace Spelprojekt.Background
{
    class RecrusiveTexture
    {
        // Hur många paneler som ska ritas ut
        private int panelAmount;
        // När nästa rad av texturer ska ritas
        private int lineInterval;

        // Lista på alla moving objects som ska ritas ut
        private List<MovingObject> panels;

        public RecrusiveTexture(Texture2D texture, float X, float Y, float speedX, float speedY, int iterationsX, int iterationsY)
        {
            lineInterval = iterationsX;
            panelAmount = iterationsX * iterationsY;

            for ()
        }

        public void Update(GameWindow window)
        {
            throw new NotImplementedException();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, Color.White);
        }

        public float X { get { return vector.X; } }
        public float Y { get { return vector.Y; } }
        public float Width { get { return texture.Width; } }
        public float Height { get { return texture.Height; } }
    }
}