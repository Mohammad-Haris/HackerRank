using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Jumping On The Clouds
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    /// </summary>

    class JumpingOnTheClouds
    {
        static int Implement (int[] clouds)
        {
            int zeroes = 0, jumps = 0;

            for (int loop = 0; loop < clouds.Length; loop++)
            {
                if (clouds[loop] == 0)
                {
                    zeroes++;
                }

                else
                {
                    jumps += zeroes / 2 + 1;
                    zeroes = 0;
                }
            }

            jumps += zeroes / 2;

            return jumps;
        }

        /// <summary>
        /// Input format:
        /// First line: Size of integer array
        /// Second line: Integer array
        /// </summary>
        
        internal static void Apply ()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = Implement(c);

            Console.WriteLine(result);
        }
    }
}
