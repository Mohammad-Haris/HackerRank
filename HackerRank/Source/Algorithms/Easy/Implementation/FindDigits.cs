using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Find Digits
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/find-digits/problem
    /// </summary>

    class FindDigits
    {
        static int Implement (int n)
        {
            int current, divisors = 0, divided = n;

            while (true)
            {
                current = divided % 10;
                divided /= 10;

                if (current != 0 && n % current == 0)
                {
                    divisors++;
                }

                if (divided == 0)
                {
                    break;
                }
            }

            return divisors;
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
