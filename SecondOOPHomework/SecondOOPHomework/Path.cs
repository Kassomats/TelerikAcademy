using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondOOPHomework
{
    class Path
    {
        private List<Point3D> holder = new List<Point3D>();


        public List<Point3D> Holder
        {
            get { return this.holder; }
            set { this.holder = value; }
        }
        public  void Add(Point3D a)
        {
            holder.Add(a);
        }
    }
}
