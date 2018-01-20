using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
 
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nodeList = new List<int>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                nodeList.Add(0);
            }
            for (int i = 0; i < numberOfCommands; i++)
            {
                int dependsOnWhich = int.Parse(Console.ReadLine());
                if (dependsOnWhich == 0)
                {
                    continue;
                }
                nodeList[dependsOnWhich - 1]++;
            }
            List<int> result = new List<int>();

            foreach (var item in nodeList)
            {
                int fact = 1;
                for (int i = 1; i <= item; i++)
                {
                    fact *= i;
                }
                result.Add(fact);
            }
            int realResult = 1;
            foreach (var num in result)
            {
                realResult *= num;
            }
            Console.WriteLine(realResult);
        }
    }
}
