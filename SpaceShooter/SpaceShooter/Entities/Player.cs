/// KONTROLLER:
///
/// W: Framåt
/// A: Vänster
/// S: Bakåt
/// D: Höger
/// Mellanslag: Färdas snabbare
/// Vänster shift: Lämna svans efter dig

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceShooter.Entities
{
    class Player
    {
        Texture2D ship_texture;
        Vector2 ship_vector;
        Vector2 ship_speed;

        public Player(Texture2D texture, float X, float Y, float speedX, float speedY)
        {

        }
    }
}
