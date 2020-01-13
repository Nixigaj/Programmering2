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
        // 
        private int lineInterval;

        // Lista på alla moving objects som ska ritas ut.
        private List<MovingObject> panels;

        public RecrusiveTexture(Texture2D texture, float X, float Y, float speedX, float speedY, int iterationsX, int iterationsY)
        {
            lineInterval = iterationsX;
            panelAmount = iterationsX * iterationsY;
            
        }

        public override void Update(GameWindow window)
        {
            throw new NotImplementedException();
        }

        public
    }
}