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
        private RecrusiveTexture back;
        private RecrusiveTexture middle;
        private RecrusiveTexture frontBottom;
        private RecrusiveTexture frontTop;

        public Background1() { }

        public void Load(ContentManager content)
        {
            back = new RecrusiveTexture("Textures/level1/background/back/", 0f, (Game1.unit - 360f) / 2f , 100, 1, 12, content);
            middle = new RecrusiveTexture("Textures/level1/background/middle/", 0f, (Game1.unit - 500f) / 2f, 100, 1, 12, content);
            frontBottom = new RecrusiveTexture(content.Load<Texture2D>("Textures/level1/background/front"), 0f, Game1.unit-64, 1000, 1);
            frontTop = new RecrusiveTexture(content.Load<Texture2D>("Textures/level1/background/frontRotated"), 0f, 0f, 1000, 1);
        }

        // Experimentativt
        static float vary = 0;
        static float maxSpeed = 0.5f;
        static float accelleration = 0.03f * maxSpeed;
        public void Update(Camera camera)
        {
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

            back.IncrementTexture();
            middle.IncrementTexture();
        }

        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            back.Draw(spriteBatch, camera);
            middle.Draw(spriteBatch, camera);
            frontBottom.Draw(spriteBatch, camera);
            frontTop.Draw(spriteBatch, camera);
        }
    }
}
