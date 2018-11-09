using System;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Strange Counter
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/strange-code/problem
    /// </summary>

    class StrangeCounter
    {
        static long Implement (long time)
        {
            switch (time)
            {
                case 1:
                    return 3;

                case 2:
                    return 2;

                case 3:
                    return 1;

                default:
                    long funcTime = 3, prevTime = 3, step = 0;
                    while (time > funcTime)
                    {
                        prevTime = funcTime;
                        funcTime = 3 + (funcTime * 2);
                        step++;
                    }
                    prevTime++;

                    return (3 * LongPow(2, step)) - (time - prevTime);
            }
        }

        static long LongPow (long x, long pow)
        {
            long result = 1;
            while (pow != 0)
            {
                result *= x;
                pow--;
            }
            return result;
        }

        /// <summary>
        /// Input format:
        /// First line: Time to find the value at
        /// </summary>
        
        internal static void Apply ()
        {
            long time = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(Implement(time));
        }
    }
}
