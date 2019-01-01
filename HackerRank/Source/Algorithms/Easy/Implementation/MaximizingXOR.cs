using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Maximizing XOR
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/maximizing-xor/problem
    /// </summary>

    static class MaximizingXOR
    {
        static int Implement (int l, int r)
        {
            List<int> xorSum = new List<int>();

            for (int oLoop = l; oLoop <= r; oLoop++)
            {
                for (int iLoop = oLoop; iLoop <= r; iLoop++)
                {
                    xorSum.Add(oLoop ^ iLoop);
                }
            }

            return xorSum.Max();
        }

        /// <summary>
        /// Input format:
        /// First line: Left limit
        /// Second line: Right limit
        /// </summary>
        
        internal static void Apply ()
        {
            int l = Convert.ToInt32(Console.ReadLine());

            int r = Convert.ToInt32(Console.ReadLine());

            int result = Implement(l, r);

            Console.WriteLine(result);
        }
    }
}