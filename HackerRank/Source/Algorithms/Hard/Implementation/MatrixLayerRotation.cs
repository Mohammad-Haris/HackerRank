using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Source.Algorithms.Hard.Implementation
{
    static class MatrixLayerRotation
    {
        /// <summary>
        /// Matrix Layer Rotation
        /// Problem solving: Algorithms
        /// Difficulty: Hard
        /// SubDomain: Implementation
        /// https://www.hackerrank.com/challenges/matrix-rotation-algo/problem
        /// </summary>

        static void Implement (List<List<int>> matrix, int rotations)
        {
            int rowLength = matrix.Count, colLength = matrix[0].Count, layers;

            if (rowLength < colLength)
            {
                layers = rowLength / 2;
            }

            else
            {
                layers = colLength / 2;
            }

            layers -= 1;

            int rot, row = rowLength - 2 * layers, col = colLength - 2 * layers;

            rot = rotations % (row * col);

            while (layers >= 0)
            {
                for (int loop = 0; loop < rot; loop++)
                {
                    Rotate(matrix, layers, rowLength, colLength);
                }

                row += 2; col += 2;

                rot = rotations % ((col * 2) + ((row - 2) * 2));

                layers--;
            }

            Console.WriteLine();

            for (int line = 0; line < matrix.Count; line++)
            {
                for (int num = 0; num < matrix[line].Count; num++)
                {
                    Console.Write(matrix[line][num] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Rotate (List<List<int>> toRotate, int level, int rowLength, int colLength)
        {
            int topLeft = toRotate[level][level],
                iterator;

            //top
            for (iterator = level; iterator < colLength - level - 1; iterator++)
            {
                toRotate[level][iterator] = toRotate[level][iterator + 1];
            }

            //right
            for (iterator = level; iterator < rowLength - level - 1; iterator++)
            {
                toRotate[iterator][colLength - level - 1] = toRotate[iterator + 1][colLength - level - 1];
            }

            //bottom
            for (iterator = colLength - level - 1; iterator >= level + 1; iterator--)
            {
                toRotate[rowLength - level - 1][iterator] = toRotate[rowLength - level - 1][iterator - 1];
            }

            //left
            for (iterator = rowLength - level - 1; iterator >= level + 1; iterator--)
            {
                toRotate[iterator][level] = toRotate[iterator - 1][level];
            }

            toRotate[level + 1][level] = topLeft;
        }

        /// <summary>
        /// Input format:
        /// First line: 3 ints seperated by space, representing row, column and rotations respectively
        /// Following lines: The matrix of size specified earlier 
        /// </summary>

        internal static void Apply ()
        {
            string[] mnr = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(mnr[0]);

            int n = Convert.ToInt32(mnr[1]);

            int r = Convert.ToInt32(mnr[2]);

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            Implement(matrix, r);
        }
    }
}
