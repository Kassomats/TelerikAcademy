using FourthOOPHomework;
using System;
using System.Collections.Generic;


namespace OverrideAndNew2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 5);
            Triangle triangle = new Triangle(3, 5);
            Square square = new Square(5);
            List<Shape> list = new List<Shape>();
            list.Add(rectangle);
            list.Add(triangle);
            list.Add(square);
            foreach (var item in list)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }
}