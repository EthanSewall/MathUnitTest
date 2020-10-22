using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix4 m4c = new Matrix4();
            m4c.SetRotateZ(2.2f);
            m4c.m13 = 55; m4c.m14 = 44; m4c.m15 = 99; m4c.m16 = 1;

            Vector4 v4a = new Vector4(13.5f, -48.23f, -54, 1);

            Vector4 v4c = m4c * v4a;

            Console.WriteLine(m4c.m1.ToString() + ", " + m4c.m2.ToString() + ", " + m4c.m3.ToString() + ", " + m4c.m4.ToString());
            Console.WriteLine(m4c.m5.ToString() + ", " + m4c.m6.ToString() + ", " + m4c.m7.ToString() + ", " + m4c.m8.ToString());
            Console.WriteLine(m4c.m9.ToString() + ", " + m4c.m10.ToString() + ", " + m4c.m11.ToString() + ", " + m4c.m12.ToString());
            Console.WriteLine(m4c.m13.ToString() + ", " + m4c.m14.ToString() + ", " + m4c.m15.ToString() + ", " + m4c.m16.ToString());
            Console.WriteLine();
            Console.WriteLine(v4a.x.ToString() + ", " + v4a.y.ToString() + ", " + v4a.z.ToString() + ", " + v4a.w.ToString());
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine(v4c.x.ToString() + ", " + v4c.y.ToString() + ", " + v4c.z.ToString() + ", " + v4a.w.ToString());
            

            Console.ReadKey();
        }
    }
}
