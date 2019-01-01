using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Sherlock and Squares
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/sherlock-and-squares/problem
    /// </summary>    

    static class SherlockAndSquares
    {
        static int Implement (int start, int end)
        {
            int bot = (int)Math.Ceiling((decimal)Math.Sqrt(start));
            int top = (int)Math.Floor((decimal)Math.Sqrt(end));

            return top - bot + 1;
        }

        /// <summary>
        /// Input format:
        /// First line: Number of test cases q
        /// Next q lines: range in integers seperated by space
        /// </summary>
        
        internal static void Apply ()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] se = Console.ReadLine().Split(' ');

                int start = Convert.ToInt32(se[0]);

                int end = Convert.ToInt32(se[1]);

                int result = Implement(start, end);

                Console.WriteLine(result);
            }
        }
    }
}
