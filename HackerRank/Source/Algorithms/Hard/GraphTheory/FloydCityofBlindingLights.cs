using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Source.Algorithms.Hard.GraphTheory
{
    /// <summary>
    /// Floyd : City of Blinding Lights
    /// Problem solving: Algorithms
    /// Difficulty: Hard
    /// SubDomain: Graph Theory
    /// https://www.hackerrank.com/challenges/floyd-city-of-blinding-lights/problem
    /// </summary>
    
    static class FloydCityofBlindingLights
    {
        /// <summary>
        /// Input format:
        /// First line: node [space] edges
        /// Following 'edge' number of lines: the two nodes between which the directed edge exists, and the length of the edge, all space seperated
        /// Next line: no of test cases
        /// Following lines: space seperated nodes between which you want the shortest distance
        /// </summary>

        static internal void Apply ()
        {
            string[] roadNodesEdges = Console.ReadLine().Split(' ');
            int roadNodes = Convert.ToInt32(roadNodesEdges[0]);
            int roadEdges = Convert.ToInt32(roadNodesEdges[1]);

            int[,] graph = new int[roadNodes, roadNodes];

            for (int oLoop = 0; oLoop < roadNodes; oLoop++)
            {
                for (int iLoop = 0; iLoop < roadNodes; iLoop++)
                {
                    if (oLoop == iLoop)
                    {
                        graph[oLoop, iLoop] = 0;
                        continue;
                    }

                    graph[oLoop, iLoop] = int.MaxValue;
                }
            }

            int[] roadFrom = new int[roadEdges];
            int[] roadTo = new int[roadEdges];
            int[] roadWeight = new int[roadEdges];

            for (int i = 0; i < roadEdges; i++)
            {
                string[] roadFromToWeight = Console.ReadLine().Split(' ');
                roadFrom[i] = Convert.ToInt32(roadFromToWeight[0]);
                roadTo[i] = Convert.ToInt32(roadFromToWeight[1]);
                roadWeight[i] = Convert.ToInt32(roadFromToWeight[2]);

                graph[roadFrom[i] - 1, roadTo[i] - 1] = roadWeight[i];
            }

            for (int i = 0; i < roadNodes; i++)
            {
                for (int j = 0; j < roadNodes; j++)
                {
                    for (int k = 0; k < roadNodes; k++)
                    {
                        if (graph[j, k] > (long)graph[j, i] + graph[i, k])
                        {
                            graph[j, k] = graph[j, i] + graph[i, k];
                        }
                    }
                }
            }

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xy = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xy[0]);

                int y = Convert.ToInt32(xy[1]);

                if (graph[x - 1, y - 1] == int.MaxValue)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(graph[x - 1, y - 1]);
                }
            }
        }
    }
}
