using System;

namespace _9
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
            bool result = solution.IsPalindrome(121);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else
            {
                int num = x;
                int reverse = 0;
                while (x != 0)
                {
                    reverse = reverse * 10 + (x % 10);
                    x = x / 10;
                }
                if (num == reverse)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
