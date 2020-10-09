using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;

        public byte red;
        public byte green;
        public byte blue;
        public byte alpha;

        public Colour()
        {
            colour = 0;
            red = 0;
            green = 0;
            blue = 0;
            alpha = 0;
        }

        public Colour(uint a, uint b, uint c, uint d)
        {
            colour = (a * 16777216) + (b * 65536) + (c * 256) + (d);
            red = (byte)a;
            green = (byte)b;
            blue = (byte)c;
            alpha = (byte)d;
        }

        public byte GetRed()
        {
            return red;
        }

        public byte GetGreen()
        {
            return green;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public void SetRed(uint newRed)
        {
            colour = (uint)((newRed * 16777216) + (green * 65536) + (blue * 256) + (alpha));
            red = (byte)newRed;
        }

        public void SetGreen(uint newGreen)
        {
            colour = (uint)((red * 16777216) + (newGreen * 65536) + (blue * 256) + (alpha));
            green = (byte)newGreen;
        }

        public void SetBlue(uint newBlue)
        {
            colour = (uint)((red * 16777216) + (green * 65536) + (newBlue * 256) + (alpha));
            blue = (byte)newBlue;
        }

        public void SetAlpha(uint newAlpha)
        {
            colour = (uint)((red * 16777216) + (green * 65536) + (blue * 256) + (newAlpha));
            alpha = (byte)newAlpha;
        }

    }
}
