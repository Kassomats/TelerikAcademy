using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<CityName, City> mydict = new Dictionary<CityName, City>();
            //mydict.Add(new CityName("Burgas"), new City());
            //mydict.Add(new CityName("Sofiaa"), new City());
            //var burgas = mydict.First().Key;
            //var sofia = mydict.Last().Key;
            //bool keysAreEqual = burgas.Equals(sofia);
            //Console.WriteLine(keysAreEqual);
            //mydict["burgas"].Country = "Bulgaria";
            //mydict["burgas"].Population = 500;
            //mydict["sofia"].Country = "Patagonia";
            //mydict["sofia"].Population = 100;
            //Console.WriteLine(mydict["burgas"].Country);
            //Console.WriteLine(mydict["burgas"].Population);
            //Console.WriteLine(mydict["sofia"].Country);
            //Console.WriteLine(mydict["sofia"].Population);
            
            
            

        }
    }
    class City
    {
        private string country;
        private int population;
        public City()
        {

        }

        public string Country { get => country; set => country = value; }
        public int Population { get => population; set => population = value; }
    }
    class CityName
    {
        private string name;
     
        public CityName(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public override bool Equals(object c)
        {
            var item = c as CityName;

            if (this.Name.Length < item.Name.Length || this.Name.Length > item.Name.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
