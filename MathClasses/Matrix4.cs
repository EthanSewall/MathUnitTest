using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

        public Matrix4(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m,  float n, float o, float p, float q)
        {
            m1 = a;
            m2 = b;
            m3 = c;
            m4 = d;
            m5 = e;
            m6 = f;
            m7 = g;
            m8 = h;
            m9 = i;
            m10 = j;
            m11 = k;
            m12 = l;
            m13 = m;
            m14 = o;
            m15 = p;
            m16 = q;
        }
    }
}
