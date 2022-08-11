using System;

namespace CountOddNumbersInAnIntervalRange
{
    public class Solution
    {
        public int CountOdds(int low, int high)
        {
            if (low % 2 == 0 && high % 2 == 0)
            {
                return (high - low) / 2;
            }
            else
            {
                return ((high - low) / 2) + 1;
            }
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            int result = solution.CountOdds(1, 100);
            Console.WriteLine(result);
        }
    }
}
