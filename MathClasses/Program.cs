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
            Matrix3 m3a = new Matrix3();
            m3a.SetRotateX(3.98f);

            Matrix3 m3c = new Matrix3();
            m3c.SetRotateZ(9.62f);

            Matrix3 m3d = m3a * m3c;

            Console.WriteLine(m3a.m1.ToString() + ", " + m3a.m2.ToString() + ", " + m3a.m3.ToString() + ", ");
            Console.WriteLine(m3a.m4.ToString() + ", " + m3a.m5.ToString() + ", " + m3a.m6.ToString() + ", ");
            Console.WriteLine(m3a.m7.ToString() + ", " + m3a.m8.ToString() + ", " + m3a.m9.ToString() + ", ");
            Console.WriteLine();

            Console.WriteLine(m3c.m1.ToString() + ", " + m3c.m2.ToString() + ", " + m3c.m3.ToString() + ", ");
            Console.WriteLine(m3c.m4.ToString() + ", " + m3c.m5.ToString() + ", " + m3c.m6.ToString() + ", ");
            Console.WriteLine(m3c.m7.ToString() + ", " + m3c.m8.ToString() + ", " + m3c.m9.ToString() + ", ");
            Console.WriteLine();

            Console.WriteLine(m3d.m1.ToString() + ", " + m3d.m2.ToString() + ", " + m3d.m3.ToString() + ", ");
            Console.WriteLine(m3d.m4.ToString() + ", " + m3d.m5.ToString() + ", " + m3d.m6.ToString() + ", ");
            Console.WriteLine(m3d.m7.ToString() + ", " + m3d.m8.ToString() + ", " + m3d.m9.ToString() + ", ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
