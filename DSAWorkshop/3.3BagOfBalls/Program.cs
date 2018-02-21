using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3._3BagOfBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger balls = input[0];
            BigInteger bagNumber = input[1];
            var bagTypes = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();
            List<BigInteger> answers = new List<BigInteger>();
            BigInteger answer = 0;
            bagTypes.Sort();
            BigInteger oldbags = 1;
            BigInteger currentBagNumber = 0;

            bool possibleToContinue = true;
            while (possibleToContinue)
            {
                possibleToContinue = false;
                for (int i = bagTypes.Count - 1; i >= 0; i--)
                {
                    if (i >= bagTypes.Count)
                    {
                        break;
                    }
                    var currentBagType = bagTypes[i];

                    if (balls % bagTypes[i] == 0 && balls != currentBagType)
                    {
                       


                        answer += oldbags;
                        currentBagNumber = balls / currentBagType;
                        oldbags *= currentBagNumber;

                        balls = currentBagType;

                        var possibleToContinueInner = true;
                        var innerAnswer = answer;
                        var innerOldBags = oldbags;
                        var innerBalls = balls;
                        var innerCurrentBagNumber = currentBagNumber;

                        while (possibleToContinueInner)
                        {
                            possibleToContinueInner = false;
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (bagTypes.Count<=k)
                                {
                                    break;
                                }
                                currentBagType = bagTypes[k];

                                if (innerBalls % bagTypes[k] == 0 && innerBalls != currentBagType)
                                {
                                    innerAnswer += innerOldBags;
                                    innerCurrentBagNumber = innerBalls / currentBagType;
                                    innerOldBags *= innerCurrentBagNumber;
                                    innerBalls = currentBagType;
                                    possibleToContinueInner = true;
                                    break;
                                }
                            }
                            if (!possibleToContinueInner)
                            {
                                answers.Add(innerAnswer);

                                possibleToContinueInner = true;
                                if (bagTypes.Count == 0)
                                {
                                    break;
                                }
                                bagTypes.Remove(bagTypes[bagTypes.Count - 1]);
                                innerAnswer = 0;
                            }
                        }


                    }
                    if (!possibleToContinue)
                    {
                        answers.Add(answer);

                        possibleToContinue = true;
                        if (bagTypes.Count == 0)
                        {
                            break;
                        }
                        bagTypes.Remove(bagTypes[bagTypes.Count - 1]);
                        answer = 0;
                    }
                }
            }
            Console.WriteLine(answers.Max());
        }
    }
}
