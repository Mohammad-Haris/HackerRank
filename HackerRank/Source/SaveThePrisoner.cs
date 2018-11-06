using System;

namespace HackerRank.Source
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
        static int Implement(int numPris, int numSwts, int start)
        {
            int result = (numSwts + start - 1) % numPris;

            if (result == 0)
            {
                return numPris;
            }

            return result;
        }

        internal static void Apply()
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