using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelprojekt.Physical
{
    class Hitbox
    {
        Rectangle rectangle = new Rectangle(new Point(100, 100), new Point(100, 100));
        Rectangle rectangle2 = new Rectangle(new Point(100, 100), new Point(100, 100));

        int hej()
        {
            bool why = rectangle.Intersects(rectangle2);
            return -1;
        }
    }
}
