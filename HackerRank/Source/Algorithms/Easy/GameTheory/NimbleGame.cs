using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Source.Algorithms.Easy.GameTheory
{
    /// <summary>
    /// Nimble Game
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Game Theory
    /// https://www.hackerrank.com/challenges/nimble-game-1/problem
    /// </summary>

    static class NimbleGame
    {
        static string Implement (int[] squares)
        {
            int sum = 0;

            for (int loop = 1; loop < squares.Length; loop++)
            {
                if (squares[loop] % 2 == 1)
                {
                    sum ^= loop;
                }
            }

            if (sum == 0)
            {
                return "Second";
            }

            else
            {
                return "First";
            }
        }

        /// <summary>
        /// Input format:
        /// First line: an array space seperated ints
        /// </summary>
        
        internal static void Apply ()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < testCases; tItr++)
            {
                int[] squares = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));

                string result = Implement(squares);

                Console.WriteLine(result);
            }
        }
    }
}
