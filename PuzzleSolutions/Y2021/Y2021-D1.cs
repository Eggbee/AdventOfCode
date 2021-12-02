using ChallengeSolutions.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleSolutions.Y2021
{
    public static class Y2021_D1
    {
        public static string SolvePart1()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);
            var increaseCount = 0;
            for (int i = 0; i < puzzleInput.Count - 1; i++)
            {
                if (puzzleInput[i] < puzzleInput[i+1])
                {
                    Console.WriteLine($"{puzzleInput[i]} (increased)");
                    increaseCount++;
                }
                else
                {
                    Console.WriteLine($"{puzzleInput[i]} (decreased)");
                }
            }
            return $"{increaseCount}";
        }

        public static string SolvePart2()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);
            var increaseCount = 0;
            for (int i = 0; i < puzzleInput.Count - 3; i++)
            {
                var sum = puzzleInput[i] + puzzleInput[i + 1] + puzzleInput[i + 2];
                var nextSum = puzzleInput[i + 1] + puzzleInput[i + 2] + puzzleInput[i + 3];
                if (sum < nextSum)
                {
                    Console.WriteLine($"{sum} (increased)");
                    increaseCount++;
                }
                else
                {
                    Console.WriteLine($"{sum} (decreased)");
                }
            }
            return $"{increaseCount}";
        }
    }
}
