using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Kangaroo
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/kangaroo/problem
    /// </summary>

    static class Kangaroo
    {
        static string Implement (int x1, int v1, int x2, int v2)
        {
            if ((x1 == x2 && v1 != v2) || (v1 == v2 && x1 != x2))
            {
                return "NO";
            }

            else
            {
                if (x1 == x2 && v1 == v2)
                {
                    return "YES";
                }

                else
                {
                    if (((x2 - x1) / (v1 - v2)) > 0 && ((x2 - x1) % (v1 - v2) == 0))
                    {
                        return "YES";
                    }

                    else
                    {
                        return "NO";
                    }
                }
            }
        }

        internal static void Apply ()
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            Console.WriteLine(Implement(x1, v1, x2, v2));
        }
    }
}
