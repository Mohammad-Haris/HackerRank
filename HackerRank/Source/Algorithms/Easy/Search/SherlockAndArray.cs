using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Search
{
    static class SherlockAndArray
    {
        /// <summary>
        /// Kangaroo
        /// Problem solving: Algorithms
        /// Difficulty: Easy
        /// SubDomain: Search
        /// https://www.hackerrank.com/challenges/sherlock-and-array/problem
        /// </summary>

        static string Implement (List<int> numList)
        {
            int leftSum, rightSum, length = numList.Count - 1;
            int loop = length / 2, start = 0, end = length;

            if (numList.Skip(1).Take(length).Sum() == 0 || numList.Take(length).Sum() == 0)
            {
                return "YES";
            }

            while (true)
            {
                leftSum = numList.Take(loop).Sum();
                rightSum = numList.Skip(loop + 1).Take(length - loop + 1).Sum();

                if (leftSum == rightSum)
                {
                    return "YES";
                }

                if (loop == end || loop == start)
                {
                    break;
                }

                else
                {
                    if (leftSum > rightSum)
                    {
                        end = loop;
                        loop = loop - (loop - start) / 2;
                    }

                    else
                    {
                        start = loop;

                        if ((end - start) / 2 == 0)
                        {
                            loop = loop + 1;
                            continue;
                        }

                        loop = loop + (end - start) / 2;
                    }
                }

            }

            return "NO";
        }

        /// <summary>
        /// Input format:
        /// First line: Number of test cases
        /// Second line: A space seperated int array
        /// </summary>

        internal static void Apply ()
        {
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                string result = Implement(arr);

                Console.WriteLine(result);
            }
        }
    }
}
