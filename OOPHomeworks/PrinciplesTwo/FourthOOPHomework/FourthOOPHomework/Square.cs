using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthOOPHomework
{
    class Square : Shape
    {
        private int width;
        private int height;
        public Square(int a)
        {
            this.width = a;
            this.height = a;
        }
        public override decimal CalculateSurface()
        {
            return width * width;
        }
    }
}
