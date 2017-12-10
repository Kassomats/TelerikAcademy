using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercise
{
    class GSMTest
    {
        public GSMTest()
        {
            GSM[] array = new GSM[3];
            array[0] = new GSM("samsung", "Sony", "Pesho");
            array[1] = new GSM("alkatel", "philips");
            array[2] = new GSM("370", "toyota", "Bobi");
            foreach (var item in array)
            {
                item.Print();
            }
        }
    }
}