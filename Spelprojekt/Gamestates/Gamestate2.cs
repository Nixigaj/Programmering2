using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Background;
using Spelprojekt.Engine;
using Spelprojekt.Entities;
using Spelprojekt.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Spelprojekt.Control;

namespace Spelprojekt.Gamestates
{
    public static class Gamestate2
    {

        private static string scoreWrite = Gamestate1.topState + "Your score: " + Gamestate1.player1.Score + " points\n\nPrevious scores:";

        private static SpriteFont defaultFont;
        private static SpriteFont largeFont;
        private static float verticalTextPos = 0;

        public static void LoadContent(ContentManager content)
        {
            defaultFont = content.Load<SpriteFont>("Fonts/Segoe");
            largeFont = content.Load<SpriteFont>("Fonts/SegoeLarge");
            LoadScore();
        }



        private static void LoadScore()
        {
            StreamReader reader = new StreamReader("../../../../Scores.txt");
            List<string> rows = new List<string>();
            while (!reader.EndOfStream) rows.Add(reader.ReadLine());
            reader.Close();

            List<int> scores = new List<int>();
            foreach (string nuvarande in rows) scores.Add(Int32.Parse(nuvarande));
            scores.Sort();
            scores.Reverse();

            int index = 1;
            foreach (int nuvarande in scores)
            {
                scoreWrite += "\n" + "(Place " + index + "): " + nuvarande.ToString() + " points";
                index++;
            }
        }



        public static void Update(GameWindow window, ContentManager content, GraphicsDeviceManager graphics, GraphicsDevice graphicsDevice)
        {
            if(Keyboard.IsPressed(Controls.uppåt))
            {
                if (verticalTextPos < 0f) verticalTextPos += 4f;
            }
            if (Keyboard.IsPressed(Controls.neråt))
            {
                verticalTextPos -= 4f;
            }
        }

        public static void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {
            spriteBatch.Begin();
            try
            {
                spriteBatch.DrawString(largeFont, "Death", new Vector2(20f, 20f + verticalTextPos), Color.Black);
                spriteBatch.DrawString(defaultFont, scoreWrite, new Vector2(30f, 100f + verticalTextPos), Color.Black);

            }
            catch { }
              
            spriteBatch.End();
        }
    }
}
