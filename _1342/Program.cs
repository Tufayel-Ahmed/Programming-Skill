using System;

namespace _1342
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            int result = solution.NumberOfSteps(10);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num - 1;
                }
                count++;
            }
            return count;
        }
    }
}
