using System;
using System.Linq;

namespace HackerRank.Source.Algorithms.Easy.Implementation
{
    /// <summary>
    /// Happy Ladybugs
    /// Problem solving: Algorithms
    /// Difficulty: Easy
    /// SubDomain: Implementation
    /// https://www.hackerrank.com/challenges/happy-ladybugs/problem
    /// </summary>

    class HappyLadybugs
    {
        static string Implement (string input)
        {
            if (input.ToUpper().IndexOf('_') != -1)
            {
                input = input.Replace("_", "");
                string distinct = new string(input.Distinct().ToArray());

                for (int outerLoop = 0; outerLoop < distinct.Length; outerLoop++)
                {
                    int count = 0;

                    for (int innerLoop = 0; innerLoop < input.Length; innerLoop++)
                    {
                        if (distinct[outerLoop] == input[innerLoop])
                        {
                            count++;
                        }
                    }

                    if (count < 2)
                    {
                        return "NO";
                    }
                }

                return "YES";
            }

            else
            {
                string distinct = new string(input.Distinct().ToArray());
                int innerLoop = 0;

                for (int outerLoop = 0; outerLoop < distinct.Length; outerLoop++)
                {
                    int count = 0;
                    while (innerLoop < input.Length && distinct[outerLoop] == input[innerLoop])
                    {
                        innerLoop++;
                        count++;
                    }

                    if (count < 2)
                    {
                        return "NO";
                    }
                }

                return "YES";
            }
        }

        internal static void Apply ()
        {
            int games = Convert.ToInt32(Console.ReadLine());

            for (int gameItr = 0; gameItr < games; gameItr++)
            {
                string input = Console.ReadLine();

                string result = Implement(input);

                Console.WriteLine(result);
            }
        }
    }
}
