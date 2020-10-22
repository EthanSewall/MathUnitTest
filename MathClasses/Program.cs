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
            Matrix3 m3c = new Matrix3();
            m3c.SetRotateZ(2.2f);
            m3c.m7 = 55; m3c.m8 = 44; m3c.m9 = 1;
            

            Vector3 v3a = new Vector3(13.5f, -48.23f, 1);

            Vector3 v3c = m3c * v3a;

            Console.WriteLine(m3c.m1.ToString() + ", " + m3c.m2.ToString() + ", " + m3c.m3.ToString() + ", ");
            Console.WriteLine(m3c.m4.ToString() + ", " + m3c.m5.ToString() + ", " + m3c.m6.ToString() + ", ");
            Console.WriteLine(m3c.m7.ToString() + ", " + m3c.m8.ToString() + ", " + m3c.m9.ToString());
            Console.WriteLine();
            Console.WriteLine(v3a.x.ToString() + ", " + v3a.y.ToString() + ", " + v3a.z.ToString());
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine(v3c.x.ToString() + ", " + v3c.y.ToString() + ", " + v3c.z.ToString());
            

            Console.ReadKey();
        }
    }
}
