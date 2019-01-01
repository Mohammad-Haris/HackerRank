using System;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    static class EqualizeTheArray
    {
        /// <summary>
        /// Equalize The Array
        /// Problem solving: Algorithms
        /// Difficulty: Easy
        /// SubDomain: Implementation
        /// https://www.hackerrank.com/challenges/equality-in-a-array/problem
        /// </summary>

        static int Implement (int[] arr)
        {
            int prevL = arr.Length, currL;

            var dictionary = arr.GroupBy(p => p).ToDictionary(g => g.Key, g => g.Count());
            int max = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Key;

            arr = arr.Where(x => x == max).ToArray();
            currL = arr.Length;

            return prevL - currL;
        }

        /// <summary>
        /// Input format:
        /// First line: Size of integer array
        /// Second line: Integer array
        /// </summary>
        
        internal static void Apply ()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = Implement(arr);

            Console.WriteLine(result);
        }
    }
}
