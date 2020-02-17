using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spelprojekt.Abstract_objects;
using Spelprojekt.Control;
using Spelprojekt.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Entities.Player
{
    class Cannon : GameObject
    {
        public Cannon(Texture2D texture, float X, float Y) : base(texture, X, Y)
        {
            this.texture = new Texture2D[1];
            this.texture[0] = texture;
            position.X = X;
            position.Y = Y;
        }

        public void Update(GameWindow window, Camera camera)
        {
            MoveTowardsMouse(camera);
        }

        private void MoveTowardsMouse(Camera camera)
        {
            float relativeRotation = Mouse.RelativeRotation(camera, X, Y);

            if (Math.Abs(relativeRotation - rotation) < 0.1f) rotation = relativeRotation;
            else if (relativeRotation > rotation) rotation += 0.1f;
            else if (relativeRotation < rotation) rotation -= 0.1f;
        }
    }
}
