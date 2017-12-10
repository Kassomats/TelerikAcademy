using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondOOPHomework
{
    static class DistanceCalc
    {
        public static double Distance(Point3D a, Point3D b)
        {
            int deltaA = a.X - b.X;
            int deltaB = a.Y - b.Y;
            int deltaC = a.Z - b.Z;
            return Math.Sqrt(deltaA * deltaA + deltaB * deltaB + deltaC * deltaC);
        }
    }
}
