using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Save The Prisoner
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/save-the-prisoner/problem
    /// </summary>

    static class SaveThePrisoner
    {
        static int Implement (int numPris, int numSwts, int start)
        {
            int result = (numSwts + start - 1) % numPris;

            if (result == 0)
            {
                return numPris;
            }

            return result;
        }

        /// <summary>
        /// Input format:
        /// First line: Number of test cases
        /// Second line: Space seperated int values for number of prisoners, number of sweets and start point
        /// </summary>
        
        internal static void Apply ()
        {
            int iterations = Convert.ToInt32(Console.ReadLine());

            for (int loop = 0; loop < iterations; loop++)
            {
                string[] nss = Console.ReadLine().Split(' ');

                int numps = Convert.ToInt32(nss[0]);

                int swts = Convert.ToInt32(nss[1]);

                int strt = Convert.ToInt32(nss[2]);

                Console.WriteLine(Implement(numps, swts, strt));
            }
        }
    }
}