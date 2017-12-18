using System;
using Bytes2you.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace _01.Exercise
{
    class GSM
    {
        private static string iPhone4S;
        private string model;
        private string manufacturer;
        private string owner;
        public static string IPhone4S1
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }


        public GSM(string model, string manufacturer)
        {
            Guard.WhenArgument(model, "model isnt null").IsNull().Throw();
            Guard.WhenArgument(manufacturer, "manufacturer isnt null").IsNull().Throw();
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            Guard.WhenArgument(owner, "owner isnt null").IsNull().Throw();
            this.owner = owner;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                Guard.WhenArgument(model, "model isnt null").IsNull().Throw();
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                Guard.WhenArgument(manufacturer, "manuf isnt null").IsNull().Throw();
                this.manufacturer = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                Guard.WhenArgument(owner, "owner isnt null").IsNull().Throw();
                this.owner = value;
            }
        }

   

        public class Battery
        {
            private string model;
            private string hoursIdle;
            private string hoursTalk;
            private enum BatteryType { };

            public Battery(string model,
             string hoursIdle,
             string hoursTalk)

            {
                this.model = model;
                this.hoursIdle = hoursIdle;
                this.hoursTalk = hoursTalk;
            }
        }
        public class Display
        {
            private int size;
            private int numColors;

            public Display(int size, int numColors)
            {
                this.numColors = numColors;
                this.size = size;
            }
        }

        public void Print()
        {
            Console.WriteLine(Model + " " + Manufacturer + " " + Owner);
        }
    }
}
