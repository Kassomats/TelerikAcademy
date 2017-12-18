using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthOOPHomework
{
    class Triangle : Shape
    {
        private int width;
        private int height;
        public Triangle(int w, int h)
        {
            this.width = w;
            this.height = h;
        }
        public override decimal CalculateSurface()
        {
            return (decimal)width * height / 2;
        }
    }
}
