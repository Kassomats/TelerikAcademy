using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMeditation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJedis = int.Parse(Console.ReadLine());
            string[] jediNames = Console.ReadLine().Split().ToArray();

            LinkedList<string> masters = new LinkedList<string>();
            LinkedList<string> knights = new LinkedList<string>();
            LinkedList<string> padowans = new LinkedList<string>();
            LinkedList<string> orderedJedis = new LinkedList<string>();
            for (int i = 0; i < numberOfJedis; i++)
            {
                
                if (jediNames[i][0] == 'M')
                {
                    masters.AddLast(jediNames[i]);
                }
                else if (jediNames[i][0] == 'K')
                {
                    knights.AddLast(jediNames[i]);
                }
                else if (jediNames[i][0] == 'P')
                {
                    padowans.AddLast(jediNames[i]);
                }
            }

            foreach (var item in masters)
            {
                orderedJedis.AddLast(item);
            }
            foreach (var item in knights)
            {
                orderedJedis.AddLast(item);
            }
            foreach (var item in padowans)
            {
                orderedJedis.AddLast(item);
            }
            Console.WriteLine(string.Join(" ",orderedJedis));

        }
    }
}
