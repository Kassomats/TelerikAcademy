using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GirlsGoneWild
{
    class Program
    {
        static int[] allShirts;
        static char[] skirts;
        static int girlsCount;
        static bool[] isVisited;
        static void Main(string[] args)
        {
            //Read input
            var numberOfShirts = int.Parse(Console.ReadLine());
            skirts = Console.ReadLine().ToCharArray();
            isVisited = new bool[skirts.Count()];
            girlsCount = int.Parse(Console.ReadLine());

            //setting structures
            var sb = new StringBuilder();
            allShirts = new int[numberOfShirts];
            for (int i = 0; i < numberOfShirts; i++)
            {
                allShirts[i] = i;
            }
            var sortedSet = new SortedSet<string>();

            //Act
            GetAllCombos(0, 0, 0, sb, sortedSet);

            //print
            Console.WriteLine(sortedSet.Count);
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }
        }
        static void GetAllCombos(int shirtToStart, int skirtToStart, int currentGirl,
                                 StringBuilder sb, SortedSet<string> answers)
        {
            if (currentGirl == girlsCount)
            {
                sb.Length -= 1;
                answers.Add(sb.ToString());
                sb.Length -= 1 + currentGirl.ToString().Length;
                return;
            }
            for (int i = shirtToStart; i < allShirts.Length; i++)
            {
                for (int k = 0; k < skirts.Length; k++)
                {
                    if (isVisited[k])
                    {
                        continue;
                    }
                    sb.Append($"{i}{skirts[k]}-");
                    isVisited[k] = true;
                    GetAllCombos(i + 1, skirtToStart + 1, currentGirl + 1, sb, answers);
                    isVisited[k] = false;
                }
            }
            if (sb.Length > 0)
            {
                sb.Length -= 3;
            }
            return;
        }

    }
}
