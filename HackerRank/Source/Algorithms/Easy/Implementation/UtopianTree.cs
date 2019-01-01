using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Utopian Tree
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/utopian-tree/problem
    /// </summary>

    static class UtopianTree
    {
        static int Implement (int cycles)
        {
            int height = 1;
            bool spring = true;

            for (int itr = 0; itr < cycles; itr++)
            {
                if (spring)
                {
                    height *= 2;
                    spring = !spring;
                    continue;
                }

                height++;
                spring = !spring;
            }

            return height;
        }

        /// <summary>
        /// Input format:
        /// First line: Number of test cases t
        /// Next t lines: Integers
        /// </summary>
        
        internal static void Apply ()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = Implement(n);

                Console.WriteLine(result);
            }
        }
    }
}
