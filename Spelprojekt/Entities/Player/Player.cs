using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Spelprojekt.Engine;
using Spelprojekt.Gamestates;
using Spelprojekt.Physical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Entities.Player
{
    public class Player
    {
        private Ship ship;
        private Cannon cannon;
        private List<Bullet> bullets = new List<Bullet>();
        private int health = 10;
        private int score = 0;

        public Player() { }

        public void Load(ContentManager content)
        {
            ship = new Ship("Textures/player/ship/", 0f, 100f, 0f, 0f, 0.1f, 0.005f, 12, content);
            cannon = new Cannon(content.Load<Texture2D>("Textures/player/cannon"), ship.X + 115f, ship.Y + 19f);
        }

        public void Update(GameWindow window, Camera camera, List<Enimy> enimies, ContentManager content)
        {
            if (ship.Update(window, enimies))
            {
                health -= 1;
                Gamestates.Gamestate1.damageInterval = 10;
            }

            cannon.Update(window, camera);

            cannon.X = ship.X + 115f;
            cannon.Y = ship.Y + 19f;

            foreach (Bullet nuvarande in bullets) nuvarande.Update();

            HandleBullets(content);

            // (Fixat nu) Ska ändras sen
            if (health <= 0) Gamestate1.InitiateDeath();
            ///////////////////////

            if ((int)ship.X / 10 > score) score = (int)ship.X / 10;
        }

        public void Draw(SpriteBatch spriteBatch, Camera camera)
        {
            foreach (Bullet nuvarande in bullets) nuvarande.DrawRotation(spriteBatch, camera);
            cannon.DrawRotation(spriteBatch, camera);
            ship.Draw(spriteBatch, camera);
        }


        bool previousMousestate = false;
        private void HandleBullets(ContentManager content)
        {
            var mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed && !previousMousestate)
            {
                bullets.Add(new Bullet("Textures/player/fireball/", cannon.CenterPosX - 8f, cannon.CenterPosY - 8f, 0f, 0f, 0f, 0f, cannon.Rotation, 60, content));
                previousMousestate = true;
            }
            else if (mouseState.LeftButton == ButtonState.Pressed) previousMousestate = true;
            else previousMousestate = false;


            // Borttagning av skott
            List<int> removeIndexes = new List<int>();
            int index = 0;
            foreach (Bullet nuvarande in bullets)
            {
                if (Math.Sqrt(Math.Pow(Math.Abs(nuvarande.X - ship.X), 2) + Math.Pow(Math.Abs(nuvarande.Y - ship.Y), 2)) > 10000f) removeIndexes.Add(index);

                index++;
            }

            try
            {
                foreach (int nuvarande in removeIndexes) bullets.RemoveAt(nuvarande);
            } catch { }

            //////////////////////////////////////////////////
        }

        public float CenterPosX { get { return ship.CenterPosX; } }
        public float CenterPosY { get { return ship.CenterPosY; } }
        public List<Bullet> Bullets { get { return bullets; } }
        public int Score { get { return score; } }
        public int Health { get { return health; } }
        
        public Hitbox[] PlayerHitboxes { get { return ship.Hitboxes; } }
    }
}
