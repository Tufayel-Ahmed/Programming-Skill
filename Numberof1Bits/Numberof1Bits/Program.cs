using System;

namespace Numberof1Bits
{
    class Program
    {
        public static void Main(String[] args)
        {
            uint n = 1010101001;

            Solution solution = new Solution();
            int result = solution.HammingWeight(n);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                n &= (n - 1);
                count++;
            }
            return count;
        }
    }
}
