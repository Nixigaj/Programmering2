using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Physical
{
    public class Hitbox
    {
        Rectangle rectangle;
        private float OffsetX;
        private float OffsetY;

        public Hitbox(Rectangle rectangle, float offsetX, float offsetY)
        {
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
            this.rectangle = new Rectangle(new Point((int)(rectangle.X + offsetX), (int)(rectangle.Y + offsetY)), new Point(rectangle.Width, rectangle.Height));
        }

        public void UpdatePos(float X, float Y)
        {
            rectangle.X = (int)(X + OffsetX);
            rectangle.Y = (int)(Y + OffsetY);
        }

        public Rectangle Rectangle { get { return rectangle; } set { rectangle = value; } }
    }
}
