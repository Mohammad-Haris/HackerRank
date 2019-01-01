using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Sequence Equation
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/permutation-equation/problem
    /// </summary>

    static class SequenceEquation
    {
        static int[] Implement (int[] p)
        {
            int length = p.Length;
            List<int> i_I = new List<int>();

            for (int oItr = 1; oItr <= length; oItr++)
            {
                for (int itr = 0; itr < length; itr++)
                {
                    if (p[itr] == oItr)
                    {
                        for (int iItr = 0; iItr < length; iItr++)
                        {
                            if (p[iItr] == itr + 1)
                            {
                                i_I.Add(iItr + 1);
                                break;
                            }
                        }

                        break;
                    }
                }
            }

            return i_I.ToArray();
        }

        /// <summary>
        /// Input format:
        /// First line: Size of integer array
        /// Second line: Integer array
        /// </summary>
        
        internal static void Apply ()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
            ;
            int[] result = Implement(p);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
