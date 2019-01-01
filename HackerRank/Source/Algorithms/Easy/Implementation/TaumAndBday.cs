using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Taum And B'day
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/taum-and-bday/problem
    /// </summary>

    static class TaumAndBday
    {
        static ulong Implement (ulong b, ulong w, ulong bc, ulong wc, ulong z)
        {
            List<ulong> costs = new List<ulong>();

            costs.Add(b * bc + w * wc);
            costs.Add(b * bc + w * bc + w * z);
            costs.Add(b * wc + w * wc + b * z);

            return costs.Min();
        }

        /// <summary>
        /// Input format:
        /// First line: Number of test cases t
        /// Next t pair of lines: 
        /// - The first line contains the values of integers b and w.
        /// - The next line contains the values of integers bc, wc, and z. 
        /// </summary>

        internal static void Apply ()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] bw = Console.ReadLine().Split(' ');

                ulong b = Convert.ToUInt64(bw[0]);

                ulong w = Convert.ToUInt64(bw[1]);

                string[] bcWcz = Console.ReadLine().Split(' ');

                ulong bc = Convert.ToUInt64(bcWcz[0]);

                ulong wc = Convert.ToUInt64(bcWcz[1]);

                ulong z = Convert.ToUInt64(bcWcz[2]);

                ulong result = Implement(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }
    }
}
