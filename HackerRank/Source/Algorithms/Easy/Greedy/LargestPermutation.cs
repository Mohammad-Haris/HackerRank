using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Source.Algorithms.Easy.Greedy
{
    static class LargestPermutation
    {
        /// <summary>
        /// Largest Permutation
        /// Problem solving: Algorithms
        /// Difficulty: Easy
        /// SubDomain: Greedy
        /// https://www.hackerrank.com/challenges/largest-permutation/problem
        /// </summary>

        static int[] Implement (int numSwaps, int[] intArr)
        {
            int arrLoop = 0, max, length = intArr.Length - 1;

            max = intArr[Max(intArr, 0)];

            if (numSwaps >= length)
            {
                while (arrLoop <= length)
                {
                    intArr[arrLoop] = max;

                    arrLoop++; max--;
                }
            }

            else
            {
                while (numSwaps > 0 && arrLoop <= length)
                {
                    if (intArr[arrLoop] == max)
                    {
                        max--; arrLoop++;
                        continue;
                    }

                    intArr[SearchMax(intArr, arrLoop, max)] = intArr[arrLoop];

                    intArr[arrLoop] = max;

                    arrLoop++; max--; numSwaps--;
                }
            }

            return intArr;
        }

        static int SearchMax (int[] intArr, int start, int max)
        {
            int loop;

            for (loop = start; loop < intArr.Length; loop++)
            {
                if (intArr[loop] == max)
                {
                    break;
                }
            }

            return loop;
        }

        static int Max (int[] intArr, int start)
        {
            int max = start;

            for (int loop = start; loop < intArr.Length; loop++)
            {
                if (intArr[loop] > intArr[max])
                {
                    max = loop;
                }
            }

            return max;
        }

        /// <summary>
        /// Input format:
        /// First line: Number of swaps
        /// Second line: Integers seperated by space
        /// </summary>

        internal static void Apply ()
        {
            int swaps = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] result = Implement(swaps, arr);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
