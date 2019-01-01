using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Angry Professor
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/angry-professor/problem
    /// </summary>

    static class AngryProfessor
    {
        static string Implement (int k, int[] a)
        {
            int oTime = 0;
            for (int itr = 0; itr < a.Length; itr++)
            {
                if (a[itr] <= 0)
                {
                    oTime++;
                }
            }

            return oTime < k ? "YES" : "NO";
        }

        /// <summary>
        /// Input format:
        /// First line: Number of test cases t
        /// Next t pair of lines: 
        /// First: The number of students n and the threshold k
        /// Second: n space seperated integers providing the arrival times
        /// </summary>
        
        internal static void Apply ()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
                string result = Implement(k, a);

                Console.WriteLine(result);
            }
        }
    }
}
