using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyInterfacesSameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Petko();
            //MyMethodFirst(test);
            //MyMethodSecond(test);
            Hasher(test);
        }
        static void Hasher(Hashing something)
        {
            something.GetHashCode();
        }
        static void MyMethodFirst(ISingFirst something)
        {
            something.Sing();
        }
        static void MyMethodSecond(ISingSecond something)
        {
            something.Sing();
        }
    }

    public class Petko : ISingFirst, ISingSecond, Hashing
    {
        void Hashing.GetHashCode()
        {
            Console.WriteLine("hello hashing dead");
        }

        void ISingFirst.Sing()
        {
            Console.WriteLine("ISingFirst");
        }

        void ISingSecond.Sing()
        {
            Console.WriteLine("ISingSecond");
        }
    }
    public interface Hashing
    {
        void GetHashCode();
    }
    public interface ISingFirst
    {
        void Sing();
    }
    public interface ISingSecond
    {
        void Sing();
    }
}
