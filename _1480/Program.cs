using System;

namespace _1491
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 1, 2, 3, 4, 5, 6 };

            int[] result = solution.RunningSum(nums);

            Array.ForEach(result, Console.WriteLine);
        }
    }
}