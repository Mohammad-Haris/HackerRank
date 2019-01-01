using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Designer PDF Viewer
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
    /// </summary>

    static class DesignerPDFViewer
    {
        static int designerPdfViewer (int[] h, string word)
        {
            List<int> sizes = new List<int>();
            int length = word.Length;

            for (int loop = 0; loop < length; loop++)
            {
                sizes.Add(h[(int)word[loop] - 97]);
            }

            return sizes.Max() * length;
        }

        /// <summary>
        /// Input format:
        /// First line: Integer array of heights of all lower cased character
        /// Second line: word to find the area of
        /// </summary>
        
        internal static void Apply ()
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
        }
    }
}
