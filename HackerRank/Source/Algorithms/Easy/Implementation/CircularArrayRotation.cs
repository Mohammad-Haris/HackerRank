using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Circular Array Rotation
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/circular-array-rotation/problem
    /// </summary>

    static class CircularArrayRotation
    {
        static int[] Implement (int[] a, int k, int[] queries)
        {
            List<int> wList = a.ToList();
            int backup, length = wList.Count - 1;

            for (int itr = 0; itr < k; itr++)
            {
                backup = wList[length];
                wList.RemoveAt(length);
                wList.Insert(0, backup);
            }

            length = queries.Length;
            int[] rValues = new int[length];

            for (int itr = 0; itr < length; itr++)
            {
                rValues[itr] = wList[queries[itr]];
            }

            return rValues;
        }

        /// <summary>
        /// Input format:
        /// The first line contains 3 space-separated integers, n, k, and q, the number of elements in the integer array, the rotation count and the number of queries
        /// The second line contains n space-separated integers
        /// </summary>

        internal static void Apply ()
        {
            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            int[] result = Implement(a, k, queries);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
