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
            Vector3 v3a = new Vector3(13.5f, -48.23f, 862);
            Vector3 v3b = new Vector3(5, 3.99f, -12);
            float dot3 = v3a.Dot(v3b);
            Console.WriteLine(dot3.ToString());
            Console.ReadKey();
        }
    }
}
