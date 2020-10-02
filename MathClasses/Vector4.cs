using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float x1, float y1, float z1, float w1)
        {
            x = x1;
            y = y1;
            z = z1;
            w = w1;
        }

        public static Vector4 operator +(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w);
        }

        public static Vector4 operator -(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w + v2.w);
        }

    }
}
