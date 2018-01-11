using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeHashTesting
{
    class Program
    {
        static void Main()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            CityBothOverrided();
            sw.Stop();
            Console.WriteLine("time taken = {0}",sw.ElapsedMilliseconds);

            sw.Restart();
            CityOnlyHashOverWrited();          
            sw.Stop();
            Console.WriteLine("time taken = {0}", sw.ElapsedMilliseconds);

            sw.Restart();
            CityNoOverWrites();
            sw.Stop();
            Console.WriteLine("time taken = {0}", sw.ElapsedMilliseconds);

            sw.Restart();
            CityOnlyEqualOverWrited();
            sw.Stop();
            Console.WriteLine("time taken = {0}", sw.ElapsedMilliseconds);

            Console.ReadKey();
        }
        private static void CityBothOverrided()
        {
            var cities = new Dictionary<CityBothOverrided, int>();
            for (int i = 10000; i < 20000; i++)
            {
                var city = new CityBothOverrided(i.ToString(), "Bulgaria", 2000000, 6);
                cities.Add(city, i);
            }
            Console.WriteLine("CityBothOverrided are created.");
        }
        private static void CityNoOverWrites()
        {
            var cities = new Dictionary<CityNoOverWrites, int>();
            for (int i = 10000; i < 20000; i++)
            {
                var city = new CityNoOverWrites(i.ToString(), "Bulgaria", 2000000, 6);
                cities.Add(city, i);
            }
            Console.WriteLine("CityNoOverWrites are created.");
        }
        private static void CityOnlyHashOverWrited()
        {
            var cities = new Dictionary<CityOnlyHashOverWrited, int>();
            for (int i = 10000; i < 20000; i++)
            {
                var city = new CityOnlyHashOverWrited(i.ToString(), "Bulgaria", 2000000, 6);
                cities.Add(city, i);
            }
            Console.WriteLine("CityOnlyHashOverWrited are created.");
        }
        private static void CityOnlyEqualOverWrited()
        {
            var cities = new Dictionary<CityOnlyEqualOverWrited, int>();
            for (int i = 10000; i < 20000; i++)
            {
                var city = new CityOnlyEqualOverWrited(i.ToString(), "Bulgaria", 2000000, 6);
                cities.Add(city, i);
            }
            Console.WriteLine("CityOnlyEqualOverWrited are created.");
        }
    }

    public class CityBothOverrided
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public double Temperature { get; set; }

        public CityBothOverrided(string name, string country, int pop, double temp)
        {
            Name = name;
            Country = country;
            Population = pop;
            Temperature = temp;
        }

        public override int GetHashCode()
        {
            return this.Name.Length;
        }

        public override bool Equals(object obj)
        {
            return this.Name == (obj as CityBothOverrided).Name;
        }
    }
    public class CityNoOverWrites
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public double Temperature { get; set; }

        public CityNoOverWrites(string name, string country, int pop, double temp)
        {
            Name = name;
            Country = country;
            Population = pop;
            Temperature = temp;
        }
    }
    public class CityOnlyHashOverWrited
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public double Temperature { get; set; }

        public CityOnlyHashOverWrited(string name, string country, int pop, double temp)
        {
            Name = name;
            Country = country;
            Population = pop;
            Temperature = temp;
        }

        public override int GetHashCode()
        {
            return this.Name.Length;
        }
    }
    public class CityOnlyEqualOverWrited
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public double Temperature { get; set; }

        public CityOnlyEqualOverWrited(string name, string country, int pop, double temp)
        {
            Name = name;
            Country = country;
            Population = pop;
            Temperature = temp;
        }
        public override bool Equals(object obj)
        {
            return this.Name == (obj as CityOnlyEqualOverWrited).Name;
        }
    }

}