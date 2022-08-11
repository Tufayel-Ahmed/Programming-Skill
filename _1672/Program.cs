using System;

namespace _1672
{
    public class Solution
    {
        public int MaximumWealth(int[,] accounts)
        {
            int max = 0;
            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts.GetLength(1); j++)
                {
                    sum = sum + accounts[i,j];
                }
                max = Math.Max(max, sum);
            }
            return max;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();

            int[,] accounts = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };

            int result = solution.MaximumWealth(accounts);

            Console.WriteLine(result);
        }
    }
}