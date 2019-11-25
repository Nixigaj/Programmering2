using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceShooter.Tools.Visual
{
    class Gradient
    {
        /// <summary>
        /// Gets an array of colors for a Top Down Gradient.
        /// </summary>
        /// <param name="width">The width of the color array.</param>
        /// <param name="height">The height of the color array.</param>
        /// <returns>Color Array.</returns>
        private static Color[] GetGradientColors(uint width, uint height)
        {
            //Declare variables
            Color[] result;
            float increment;
            int color;

            //Determine that both height and width are greater than 0
            if (!(width > 0 && height > 0))
            //exit the function with a null color array
            { return null; }

            //Setup the result array
            result = new Color[width * height];

            //Calculate the increment values
            increment = (float)255 / (result.Length);

            //Loop through each color
            for (int i = 0; i < result.Length; i++)
            {
                color = (int)(increment * i);

                result[i] = new Color(
                    color,
                    color,
                    color);
            }

            //return the color
            return result;
        }
    }
}
