using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondOOPHomework
{
    static class PathStorage
    {
        public static void Save(Path a)
        {
            using (var writer = new StreamWriter("../../../test.txt"))
            {
                foreach (var item in a.Holder)
                {
                    writer.WriteLine(item);
                }
             
            }
        }
    }
}
