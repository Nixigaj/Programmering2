using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spelprojekt.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Background
{
    public class Background1
    {
        private RecrusiveTexture[] layers = new RecrusiveTexture[4];
        public Background1() { }

        public void Load(ContentManager content)
        {
            layers[0] = new RecrusiveTexture("Textures/level1/background/back/", 0f, (Game1.unit - 360f) / 2f, 100, 1, 12, 2, content);
            layers[1] = new RecrusiveTexture("Textures/level1/background/middle/", 0f, (Game1.unit - 500f) / 2f, 100, 1, 12, 1, content);
            layers[2] = new RecrusiveTexture(content.Load<Texture2D>("Textures/level1/background/front"), 0f, Game1.unit - 64, 100, 1, 0);
            layers[3] = new RecrusiveTexture(content.Load<Texture2D>("Textures/level1/background/frontRotated"), 0f, 0f, 100, 1, 0);
        }

        // Experimentativt
        /*
        static float vary = 0;
        static float maxSpeed = 0.5f;
        static float accelleration = 0.03f * maxSpeed;
        */

        public void Update(Camera camera)
        {
            /*
            // Experimentativt
            KeyboardState keyboardState = Keyboard.GetState();

            if (!keyboardState.IsKeyDown(Keys.D) && !keyboardState.IsKeyDown(Keys.A))
            {
                if (Math.Abs(vary) < accelleration) vary = 0;
                else if (vary > 0) vary -= accelleration;
                else if (vary < 0) vary += accelleration;
            }
            else
            {
                if (keyboardState.IsKeyDown(Keys.A))
                {
                    if (vary < 0) vary += accelleration * 4;
                    else if (vary < maxSpeed) vary += accelleration * 2;
                    else if (vary > maxSpeed) vary = maxSpeed;
                }
                if (keyboardState.IsKeyDown(Keys.D))
                {
                    if (vary > 0) vary -= accelleration * 4;
                    else if (vary > -maxSpeed) vary -= accelleration * 2;
                    else if (vary < -maxSpeed) vary = -maxSpeed;
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////
            

            back.Move(10f * vary, 0f);
            middle.Move(12f * vary, 0f);
            frontBottom.Move(18f * vary, 0f);
            frontTop.Move(18f * vary, 0f);
            */



            GetLayer(AvailableLayers.back).IncrementTexture();
            GetLayer(AvailableLayers.middle).IncrementTexture();
            CheckWidth(camera);
            CheckPos(camera);
        }

        public RecrusiveTexture GetLayer(AvailableLayers layer)
        {
            switch(layer)
            {
                case AvailableLayers.back: return layers[0];
                case AvailableLayers.middle: return layers[1];
                case AvailableLayers.frontBottom: return layers[2];
                case AvailableLayers.frontTop: return layers[3];
                default: return null;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            foreach (RecrusiveTexture nuvarande in layers) nuvarande.Draw(spriteBatch, camera, -2, 0);
        }

        public void Draw(AvailableLayers layer, SpriteBatch spriteBatch, Camera camera)
        {
            GetLayer(layer).Draw(spriteBatch, camera, -2, 0);
        }

        private void CheckWidth(Camera camera)
        {
            foreach (RecrusiveTexture nuvarande in layers)
            {
                // +2 för konvertering till int tar bort decimaler men texturen måste räcka till kanten av skärmen.
                nuvarande.IterationsX = (int)(camera.WindowWidth / nuvarande.Width + 4);
            } 
        }

        private void CheckPos(Camera camera)
        {
            foreach (RecrusiveTexture nuvarande in layers)
            {
                while (-camera.X - (nuvarande.X * nuvarande.ParralaxFactor) > nuvarande.Width) nuvarande.NudgeX(1);
                while (-camera.X - (nuvarande.X * nuvarande.ParralaxFactor) < -nuvarande.Width) nuvarande.NudgeX(-1);
            }
        }
    }

    public enum AvailableLayers
    {
        back, middle, frontBottom, frontTop
    }
}
