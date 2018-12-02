using System;

namespace HackerRank.Source.Algorithms.Hard.DynamicProgramming
{
    static class HexagonalGrid
    {
        /// <summary>
        /// Hexagonal Grid
        /// Problem solving: Algorithms
        /// Difficulty: Hard
        /// SubDomain: Dynamic Programming
        /// https://www.hackerrank.com/challenges/hexagonal-grid/problem
        /// </summary>

        static string Implement (string top, string bot)
        {
            int zeroes = 0, length = top.Length;
            bool evened = true;

            for (int loop = 0; loop < length; loop++)
            {
                if (top[loop] == '0')
                {
                    if (loop == 0)
                    {
                        zeroes++;
                    }

                    else if (top[loop - 1] == '0' || bot[loop - 1] == '0')
                    {
                        zeroes++;
                    }

                    else
                    {
                        if (zeroes % 2 == 1)
                        {
                            evened = false;
                            break;
                        }

                        zeroes++;
                    }
                }

                if (bot[loop] == '0')
                {
                    if (loop == 0)
                    {
                        zeroes++;
                    }
                    else if (top[loop] == '0' || bot[loop - 1] == '0')
                    {
                        zeroes++;
                    }
                    else
                    {
                        if (zeroes % 2 == 1)
                        {
                            evened = false;
                            break;
                        }

                        zeroes++;
                    }
                }

            }

            if (zeroes % 2 == 1)
            {
                evened = false;

            }

            if (evened)
            {
                return "YES";
            }

            return "NO";
        }

        /// <summary>
        /// Input format:
        /// First line: no of test cases
        /// Second line: length of grid
        /// Third and fourth line: binary string of length n specifying empty space with a 0 and filled space with a 1
        /// </summary>
        
        internal static void Apply ()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string a = Console.ReadLine();

                string b = Console.ReadLine();

                string result = Implement(a, b);

                Console.WriteLine(result);
            }
        }
    }
}
