using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondOOPHomework
{
    struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);
       
        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        static public Point3D PointO { get; set; }
        public void Print()
        {
            Console.WriteLine("{0}{1}{2}",X,Y,Z);
        }
    }
}
