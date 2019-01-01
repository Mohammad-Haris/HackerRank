using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Cut The Sticks
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/cut-the-sticks/problem
    /// </summary>

    static class CutTheSticks
    {
        static int[] Implement (int[] arr)
        {
            List<int> result = new List<int>();

            result.Add(arr.Length);
            int max = arr.Max(), min = arr.Min();

            while (true)
            {
                for (int loop = 0; loop < arr.Length; loop++)
                {
                    arr[loop] = arr[loop] - min;
                }
                max = arr.Max();

                if (max == 0)
                {
                    break;
                }

                arr = arr.Where(x => x != 0).ToArray();
                min = arr.Min();
                result.Add(arr.Length);
            }

            return result.ToArray();
        }

        /// <summary>
        /// Input format:
        /// First line: Size of integer array
        /// Second line: Integer array
        /// </summary>

        internal static void Apply ()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] result = Implement(arr);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
