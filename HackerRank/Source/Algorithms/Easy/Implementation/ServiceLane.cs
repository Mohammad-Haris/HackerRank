using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Service Lane
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/service-lane/problem
    /// </summary>

    static class ServiceLane
    {
        static int[] Implement (int[] width, int[][] cases)
        {
            int length = cases.Length, min;
            int[] mins = new int[length];

            for (int oItr = 0; oItr < length; oItr++)
            {
                min = width[cases[oItr][0]];
                for (int iItr = cases[oItr][0]; iItr <= cases[oItr][1]; iItr++)
                {
                    if (min > width[iItr])
                    {
                        min = width[iItr];
                    }
                }

                mins[oItr] = min;
            }

            return mins;
        }

        /// <summary>
        /// Input format:
        /// First line: The first line of input contains two integers, n and t i.e. width and test cases
        /// Second line: N space seperated integers for width
        /// Next t lines: two space seperated integers        
        /// </summary>

        internal static void Apply ()
        {
            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp));

            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] result = Implement(width, cases);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
