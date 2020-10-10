using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        public Matrix3(float a, float b, float c, float d, float e, float f, float g, float h, float i)
        {
            m1 = a;  m2 = d;  m3 = g;
            m4 = b;  m5 = e;  m6 = h;
            m7 = c;  m8 = f;  m9 = i;
        }

        public static Matrix3 operator *(Matrix3 left, Matrix3 right)
        {
            Matrix3 result = new Matrix3();
            Vector3 v1;
            Vector3 v2;

            v1 = new Vector3(left.m1, left.m2, left.m3);
            v2 = new Vector3(right.m1, right.m4, right.m7);
            result.m1 = v1.Dot(v2);
            v1 = new Vector3(left.m1, left.m2, left.m3);
            v2 = new Vector3(right.m2, right.m5, right.m8);
            result.m4 = v1.Dot(v2);
            v1 = new Vector3(left.m1, left.m2, left.m3);
            v2 = new Vector3(right.m3, right.m6, right.m9);
            result.m7 = v1.Dot(v2);
            v1 = new Vector3(left.m4, left.m5, left.m6);
            v2 = new Vector3(right.m1, right.m4, right.m7);
            result.m2 = v1.Dot(v2);
            v1 = new Vector3(left.m4, left.m5, left.m6);
            v2 = new Vector3(right.m2, right.m5, right.m8);
            result.m5 = v1.Dot(v2);
            v1 = new Vector3(left.m4, left.m5, left.m6);
            v2 = new Vector3(right.m3, right.m6, right.m9);
            result.m8 = v1.Dot(v2);
            v1 = new Vector3(left.m7, left.m8, left.m9);
            v2 = new Vector3(right.m1, right.m4, right.m7);
            result.m3 = v1.Dot(v2);
            v1 = new Vector3(left.m7, left.m8, left.m9);
            v2 = new Vector3(right.m2, right.m5, right.m8);
            result.m6 = v1.Dot(v2);
            v1 = new Vector3(left.m7, left.m8, left.m9);
            v2 = new Vector3(right.m3, right.m6, right.m9);
            result.m9 = v1.Dot(v2);

            return result;
        }

        public static Vector3 operator *(Matrix3 left, Vector3 right)
        {
            Vector3 result = new Vector3();
            result.x = right.Dot(new Vector3(left.m1, left.m4, left.m7));
            result.y = right.Dot(new Vector3(left.m2, left.m5, left.m8));
            result.z = right.Dot(new Vector3(left.m3, left.m6, left.m9));
            return result;
        }
    }
}