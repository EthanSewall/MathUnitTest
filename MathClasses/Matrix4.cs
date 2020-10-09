﻿using System;
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

        public Matrix4(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m,  float n, float o, float p)
        {
            m1 = a; m2 = e; m3 = i; m4 = m;
            m5 = b; m6 = f; m7 = j; m8 = n;
            m9 = c; m10= g; m11= k; m12= o;
            m13= d; m14= h; m15= l; m16= p;
        }
   
        public static Matrix4 operator *(Matrix4 left, Matrix4 right)
        {
            Matrix4 result = new Matrix4();
            Vector4 v1;
            Vector4 v2;

            v1 = new Vector4(left.m1, left.m2, left.m3, left.m4);
            v2 = new Vector4(right.m1, right.m5, right.m9, right.m13);
            result.m1 = v1.Dot(v2);
            v1 = new Vector4(left.m1, left.m2, left.m3, left.m4);
            v2 = new Vector4(right.m2, right.m6, right.m10, right.m14);
            result.m5 = v1.Dot(v2);
            v1 = new Vector4(left.m1, left.m2, left.m3, left.m4);
            v2 = new Vector4(right.m3, right.m7, right.m11, right.m15);
            result.m9 = v1.Dot(v2);
            v1 = new Vector4(left.m1, left.m2, left.m3, left.m4);
            v2 = new Vector4(right.m4, right.m8, right.m12, right.m16);
            result.m13 = v1.Dot(v2);
            v1 = new Vector4(left.m5, left.m6, left.m7, left.m8);
            v2 = new Vector4(right.m1, right.m5, right.m9, right.m13);
            result.m2 = v1.Dot(v2);
            v1 = new Vector4(left.m5, left.m6, left.m7, left.m8);
            v2 = new Vector4(right.m2, right.m6, right.m10, right.m14);
            result.m6 = v1.Dot(v2);
            v1 = new Vector4(left.m5, left.m6, left.m7, left.m8);
            v2 = new Vector4(right.m3, right.m7, right.m11, right.m15);
            result.m10 = v1.Dot(v2);
            v1 = new Vector4(left.m5, left.m6, left.m7, left.m8);
            v2 = new Vector4(right.m4, right.m8, right.m12, right.m16);
            result.m14 = v1.Dot(v2);
            v1 = new Vector4(left.m9, left.m10, left.m11, left.m12);
            v2 = new Vector4(right.m1, right.m5, right.m9, right.m13);
            result.m3 = v1.Dot(v2);
            v1 = new Vector4(left.m9, left.m10, left.m11, left.m12);
            v2 = new Vector4(right.m2, right.m6, right.m10, right.m14);
            result.m7 = v1.Dot(v2);
            v1 = new Vector4(left.m9, left.m10, left.m11, left.m12);
            v2 = new Vector4(right.m3, right.m7, right.m11, right.m15);
            result.m11 = v1.Dot(v2);
            v1 = new Vector4(left.m9, left.m10, left.m11, left.m12);
            v2 = new Vector4(right.m4, right.m8, right.m12, right.m16);
            result.m15 = v1.Dot(v2);
            v1 = new Vector4(left.m13, left.m14, left.m15, left.m16);
            v2 = new Vector4(right.m1, right.m5, right.m9, right.m13);
            result.m4 = v1.Dot(v2);
            v1 = new Vector4(left.m13, left.m14, left.m15, left.m16);
            v2 = new Vector4(right.m2, right.m6, right.m10, right.m14);
            result.m8 = v1.Dot(v2);
            v1 = new Vector4(left.m13, left.m14, left.m15, left.m16);
            v2 = new Vector4(right.m3, right.m7, right.m11, right.m15);
            result.m12 = v1.Dot(v2);
            v1 = new Vector4(left.m13, left.m14, left.m15, left.m16);
            v2 = new Vector4(right.m4, right.m8, right.m12, right.m16);
            result.m16 = v1.Dot(v2);

            return result;
        }
    }
}
