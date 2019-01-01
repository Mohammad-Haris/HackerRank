using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Chocolate Feast
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/chocolate-feast/problem
    /// </summary>

    static class ChocolateFeast
    {
        static int Implement (int n, int c, int m)
        {
            int chocs = n / c, wrappers = chocs, remW;

            while (wrappers / m != 0)
            {
                remW = wrappers % m;
                wrappers /= m;
                chocs += wrappers;
                wrappers += remW;
            }

            return chocs;
        }

        /// <summary>
        /// Input format:
        /// First line: Number of test cases t
        /// Next t lines: Money m, cost c and an integer representing the number of wrappers he can turn in for a free bar m
        /// </summary>

        internal static void Apply ()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);

                int c = Convert.ToInt32(ncm[1]);

                int m = Convert.ToInt32(ncm[2]);

                int result = Implement(n, c, m);

                Console.WriteLine(result);
            }
        }
    }
}
