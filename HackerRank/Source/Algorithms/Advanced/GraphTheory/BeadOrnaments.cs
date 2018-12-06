using System;
using System.Linq;
using System.Numerics;

namespace HackerRank.Source.Algorithms.Advanced.GraphTheory
{
    /// <summary>
    /// Bead Ornaments
    /// Problem solving: Algorithms
    /// Difficulty: Advanced
    /// SubDomain: Graph Theory
    /// https://www.hackerrank.com/challenges/beadornaments/problem
    /// </summary>

    class BeadOrnaments
    {
        static int Implement (int[] colors)
        {
            BigInteger ornaments = 1;
            int length = colors.Length;

            if (length > 1)
            {
                foreach (int color in colors)
                {
                    ornaments *= color;
                    if (color <= 2) continue;
                    ornaments *= BigInteger.Pow(color, color - 2);
                    ornaments %= 1000000007;
                }
            }

            else
            {
                foreach (int color in colors)
                {
                    if (color <= 2) continue;
                    ornaments *= BigInteger.Pow(color, color - 2);
                    ornaments %= 1000000007;
                }
            }

            if (length > 2) ornaments *= BigInteger.Pow(colors.Sum(), length - 2);

            return (int)(ornaments % 1000000007);
        }

        /// <summary>
        /// Input format:
        /// First line: number of test cases
        /// Second line: number of colors
        /// Third line: space seperated number of beads per color
        /// </summary>
        
        static internal void Apply ()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int bCount = Convert.ToInt32(Console.ReadLine());
                int[] colors = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
                int result = Implement(colors);

                Console.WriteLine(result);
            }
        }
    }
}
