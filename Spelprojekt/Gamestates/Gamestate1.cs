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

namespace Spelprojekt.Gamestates
{
    public static class Gamestate1
    {
        //Variabler
        public static float unit = 540f; // 1 unit är lika lång som den logiska höjden på banan
        public static Camera camera1 = new Camera(0, 0);
        public static Background1 background1 = new Background1();
        public static Player player1 = new Player();
        public static List<Enimy> enimies = new List<Enimy>();
        private static SpriteFont defaultFont;

        public static void LoadContent(ContentManager content)
        {
            player1.Load(content);
            background1.Load(content);
            defaultFont = content.Load<SpriteFont>("Fonts/Segoe");
        }

        public static int damageInterval = 0;
        public static void Update(GameWindow window, ContentManager content, GraphicsDeviceManager graphics, GraphicsDevice graphicsDevice)
        {
            player1.Update(window, camera1, Gamestates.Gamestate1.enimies, content);

            camera1.ApproachX(player1.CenterPosX - 250f * camera1.WidthFactor, 0.01f, 1.2f, 3);

            background1.Update(camera1);

            camera1.Update(graphics, graphicsDevice);

            AddEnimy(content);

            HandleEnimies();

            if (damageInterval > 0) damageInterval--;
        }

        private static Color GetCurrentTextColor()
        {
            if (damageInterval > 0) return Color.Red;
            else return Color.White;
        }

        private static void HandleEnimies()
        {
            int index = 0;
            List<int> removeIndex = new List<int>();
            foreach (Enimy nuvarande in enimies)
            {
                if (nuvarande.Update(player1.CenterPosX, player1.CenterPosY, player1.Bullets, player1.Score/1000f)) removeIndex.Add(index);
            }

            try
            {
                foreach (int nuvarande in removeIndex) enimies.RemoveAt(nuvarande);
            } catch { }
            
        }

        public static void Draw(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {
            spriteBatch.Begin(SpriteSortMode.Immediate, null, SamplerState.PointWrap, null, null, null, Matrix.CreateScale(camera1.Scaling));   // Starta "bildUppritaren"
            background1.Draw(spriteBatch, camera1);
            player1.Draw(spriteBatch, camera1);

            foreach (Enimy nuvarande in enimies) nuvarande.Draw(spriteBatch, camera1);


            //graphicsDevice.DrawUserPrimitives(PrimitiveType.LineStrip, player1.PlayerHitboxes[0].Rectangle, null, null);


            spriteBatch.End();  // Stäng av "bildUppritaren"

            spriteBatch.Begin();
            spriteBatch.DrawString(defaultFont, "Score: " + player1.Score + " points" + "\n" + "Health: " + GetHealthString(), new Vector2(10f, 10f), GetCurrentTextColor());
            spriteBatch.End();
        }

        private static string GetHealthString()
        {
            string returnString = "";
            for(int i = 1; i <= player1.Health; i++)
            {
                returnString += "O";
            }
            return returnString;
        }

        private static void AddEnimy(ContentManager content)
        {
            if (RandomOccurance(player1.Score/50))
            {
                if (RandomBool())
                {
                    enimies.Add(new Enimy("Textures/level1/slime/", RandomFloat(0, 800) + player1.CenterPosX -100f, -30f, 0, 0.5f, 0.1f, 0.005f, 12, content));
                }
                else
                {
                    enimies.Add(new Enimy("Textures/level1/slime/", RandomFloat(0, 800) + player1.CenterPosX -100f, unit, 0, -0.5f, 0.1f, 0.005f, 12, content));
                }
            }
        }


        private static Random gen = new Random();
        private static float RandomFloat(float max, float min)
        {
            return (float) gen.NextDouble() * (min - max) + min;
        }  
        private static bool RandomOccurance(float probability)
        {
            Random gen = new Random();
            int range = gen.Next(1000);
            return range <= probability;
        }

        private static bool RandomBool()
        {
            return gen.NextDouble() >= 0.5;
        }



        public static void InitiateDeath()
        {
            WriteScore();

            
            Game1.gamestate = Game1.Gamestate.Dead;
        }


        public static string topState = "";

        public static void WriteScore()
        {
            StreamReader reader = new StreamReader("../../../../Scores.txt");
            List<string> rows = new List<string>();
            while (!reader.EndOfStream) rows.Add(reader.ReadLine());
            reader.Close();

            List<int> scores = new List<int>();
            foreach (string nuvarande in rows) scores.Add(Int32.Parse(nuvarande));
            scores.Sort();
            scores.Reverse();

            writeTopState(scores);

            StreamWriter writer = new StreamWriter("../../../../Scores.txt", append: true);
            writer.WriteLine(player1.Score.ToString());
            writer.Close();
        }

        private static void writeTopState(List<int> scores)
        {
            try
            {
                if (player1.Score > scores[0])
                {
                    topState += "Congratulations! You reached 1st place.\n";
                    return;
                }
            }
            catch
            {
                topState += "Congratulations! You reached 1st place.\n";
                return;
            }

            try
            {
                if (player1.Score > scores[1])
                {
                    topState += "Congratulations! You reached 2nd place.\n";
                    return;
                }
            }
            catch
            {
                topState += "Congratulations! You reached 2nd place.\n";
                return;
            }

            try
            {
                if (player1.Score > scores[2])
                {
                    topState += "Congratulations! You reached 3rd place.\n";
                    return;
                }
            }
            catch
            {
                topState += "Congratulations! You reached 3rd place.\n";
                return;
            }

            /*
            else if (player1.Score > scores[1]) topState += "Congratulations! You reached 2nd place.\n";
            else if (player1.Score > scores[2]) topState += "Congratulations! You reached 3rd place.\n";
            */
        }
    }
}
