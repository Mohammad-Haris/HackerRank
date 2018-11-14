using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Source.Algorithms.Easy.BitManipulation
{
    static class SumOrXOR
    {
        /// <summary>
        /// Sum or XOR
        /// Problem solving: Algorithms
        /// Difficulty: Easy
        /// SubDomain: Bit Manipulation
        /// https://www.hackerrank.com/challenges/sum-vs-xor/problem
        /// </summary>

        static long Implement (long num)
        {
            int zeroBits = 0;

            while (num != 0)
            {
                if (num % 2 == 1)   // the information we get from this mod is that the num is at least greater than 2. other than in the case of 1
                {
                    zeroBits++;
                }

                num /= 2;           // skips through bits
            }

            return LongPow(zeroBits);
        }

        static long LongPow (int pow)
        {
            long result = 1;
            while (pow != 0)
            {
                result *= 2;
                pow--;
            }
            return result;
        }

        /// <summary>
        /// Input format:
        /// First line: long number        
        /// </summary>
        
        internal static void Apply ()
        {
            long num = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Implement(num);

            Console.WriteLine(result);
        }
    }
}
