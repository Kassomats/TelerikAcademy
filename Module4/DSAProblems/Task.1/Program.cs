using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int hello = 5;
            hello = hello.UpAnyInt();
            Console.WriteLine(hello);
        }
        static void UpMyCount(int asd)
        {
            if (asd==5)
            {
                
                return;
            }
            asd++;
            UpMyCount(asd);
            Console.WriteLine(asd);
        }
        
    }
    
    public class MyBox<T>
    {
        private readonly T name;

        public MyBox(T name)
        {
            this.name = name;
        }
        public void MyName()
        {
            Console.WriteLine(name);
        }
    }
    public static class Extensions
    {
        public static int UpAnyInt(this int test)
        {
            return test++;
        }

        public static void ShowMyTypes<T>(this List<T> crazy) 
        {
            Console.WriteLine(typeof(T));
        }
    }
}
