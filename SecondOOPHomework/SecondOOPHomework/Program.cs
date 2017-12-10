using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondOOPHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(5, 4, 222);
            Point3D point2 = new Point3D(3, 2, 9);
            //Console.WriteLine(DistanceCalc.Distance(point,point2));
            Path holder = new Path();
            holder.Add(point);
            holder.Add(point2);
            PathStorage.Save(holder);


        }
    }
}
