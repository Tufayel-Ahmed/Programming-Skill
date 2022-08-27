using System;

namespace LargestPerimeterTriangle
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8,9};

            Solution solution = new Solution();
            int result = solution.LargestPerimeter(nums);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            for (int i = nums.Length - 3; i >= 0; --i)
            {
                if ((nums[i] + nums[i + 1]) > nums[i + 2])
                {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }
            return 0;
        }
    }
}
