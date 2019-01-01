using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    static class MinimumDistances
    {
        /// <summary>
        /// Minumum Distances
        /// Problem solving: Algorithms
        /// Difficulty: Easy
        /// SubDomain: Implementation
        /// https://www.hackerrank.com/challenges/minimum-distances/problem
        /// </summary>

        static int Implement (int[] arr)
        {
            int length = arr.Length;
            List<int> diffL = new List<int>();

            for (int oLoop = 0; oLoop < length - 1; oLoop++)
            {
                for (int iLoop = oLoop + 1; iLoop < length; iLoop++)
                {
                    if (arr[oLoop] == arr[iLoop])
                    {
                        diffL.Add(Math.Abs(iLoop - oLoop));
                    }
                }
            }

            return !diffL.Any() ? -1 : diffL.Min();
        }

        /// <summary>
        /// Input format:
        /// First line: Size of integer array
        /// Second line: Integer array
        /// </summary>

        internal static void Apply ()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int result = Implement(a);

            Console.WriteLine(result);
        }
    }
}
