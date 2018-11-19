using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Source.Algorithms.Easy.Greedy
{
    /// <summary>
    /// Beautiful Pairs
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Greedy
    /// https://www.hackerrank.com/challenges/beautiful-pairs/problem
    /// </summary>

    static class BeautifulPairs
    {
        static int Implement (List<int> firstList, List<int> secondList)
        {
            int pair = 0, skipIndex;

            for (int outerLoop = 0; outerLoop < firstList.Count; outerLoop++)
            {
                skipIndex = GetIndex(secondList, firstList[outerLoop]);

                if (skipIndex != -1)
                {
                    pair++;
                    secondList.RemoveAt(skipIndex);
                }
            }


            if (pair < firstList.Count)
            {
                pair++;
                return pair;
            }

            else
            {
                pair--;
                return pair;
            }
        }

        static int GetIndex (List<int> intArr, int num)
        {
            int index, result = -1;

            for (index = 0; index < intArr.Count; index++)
            {
                if (intArr[index] == num)
                {
                    result = index;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Input format:
        /// First line: an array of space seperated ints
        /// Second line: an array of space seperated ints
        /// </summary>

        internal static void Apply ()
        {
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            firstList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            secondList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Implement(firstList, secondList);

            Console.WriteLine(result);
        }
    }
}
