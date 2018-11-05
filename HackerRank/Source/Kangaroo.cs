using System;

namespace HackerRank.Source
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
        static string Apply(int x1, int v1, int x2, int v2)
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

        static bool Validate(int x1, int v1, int x2, int v2)
        {
            if (x1 > 10000 || x1 < 0 || x2 > 10000 || x2 < 0 || v1 < 1 || v1 > 10000 || v2 < 1 || v2 > 10000)
            {
                return false;
            }

            return true;
        }

        internal static void Call()
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            if (Validate(x1, v1, x2, v2))
            {
                string result = Apply(x1, v1, x2, v2);
                Console.WriteLine(result);
            }

            else
            {
                throw new Exception("Invalid Input");
            }
        }
    }
}
